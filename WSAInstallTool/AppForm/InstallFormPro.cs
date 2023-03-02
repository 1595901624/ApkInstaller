using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSAInstallTool.AppForm;
using WSAInstallTool.Util;

namespace WSAInstallTool
{
    public partial class InstallFormPro : Form
    {
        private String[] args = null;

        // 额外的设备命令
        private string extraCommand = "";

        private string apkPath = "";

        // 完整的权限列表
        private List<string> permissionList;

        private AAPTParseUtil aaptParseUtil;

        // Cmd 回调委托
        private delegate void CmdCallbackDelegate(string result);

        // 检测apk是否存在风险的委托
        private delegate void BadApkDelegate(bool isBad);

        public InstallFormPro()
        {
            InitializeComponent();
        }

        public InstallFormPro(String[] args)
        {
            this.args = args;
            InitializeComponent();
        }

        private void InstallFormPro_Load(object sender, EventArgs e)
        {
            // 提前开启Adb服务
            InitAdbServer();
            InitLanguage();
            Console.WriteLine("dir == " + Environment.CurrentDirectory);
            //MessageBox.Show("" + System.Threading.Thread.GetDomain().BaseDirectory);
            //apkPath = @"C:\Users\luhao\Downloads\stardance_1.0.3_Beta.apk";
            if (args != null && args.Length > 0)
            {
                apkPath = args[0];
            }

            //string apkPath = "C:\\Users\\haoyu\\Desktop\\106_f0c49f2b285b39d89d87a3c5747ea155.apk";

            string result = CMDUtil.ExecCMD("aapt.exe", "dump badging \"" + apkPath + "\"");

            aaptParseUtil = new AAPTParseUtil(result);

            // 包名
            packageNameLabel.Text = LangUtil.Instance.GetPackageName() +
                (string.IsNullOrEmpty(aaptParseUtil.GetPackageName()) ? LangUtil.Instance.GetAppUnknown() : aaptParseUtil.GetPackageName());
            versionNameLabel.Text = LangUtil.Instance.GetVersionName() +
                (string.IsNullOrEmpty(aaptParseUtil.GetVersionName()) ? LangUtil.Instance.GetAppUnknown() : aaptParseUtil.GetVersionName()); ;
            minVersionLabel.Text = LangUtil.Instance.GetMinVersionName() + aaptParseUtil.getMinSupportVersion();

            // 判断APK状态
            BadApkDelegate badApkDelegate = CheckApkSafetyComplete;
            Thread ts = new Thread(CheckApkSafety);
            ts.Start(badApkDelegate);

            // 权限
            StringBuilder permissionStringBuilder = new StringBuilder();
            permissionList = aaptParseUtil.GetPermissionDetailList();
            if (permissionList.Count > 10)
            {
                foreach (string s in permissionList.GetRange(0, 10))
                {
                    permissionStringBuilder.Append("· ").Append(s).Append("\n");
                }
                permissionStringBuilder.Append("  ......");
                moreLinkLabel.Visible = true;
            }
            else
            {
                foreach (string s in permissionList)
                {
                    permissionStringBuilder.Append("· ").Append(s).Append("\n");
                }
                moreLinkLabel.Visible = false;
            }
            permissionLabel.Text = LangUtil.Instance.GetPersimissions() + "\n"
                + (string.IsNullOrEmpty(permissionStringBuilder.ToString().Trim()) ? LangUtil.Instance.GetNothing() : permissionStringBuilder.ToString().Trim());

            // APP 名称
            appNameLabel.Text = string.IsNullOrEmpty(aaptParseUtil.GetAppName()) ? LangUtil.Instance.GetAppUnknown() : aaptParseUtil.GetAppName();

            // APP 大小
            spaceLabel.Text = LangUtil.Instance.GetSize() + GetApkSpace();

            // 获取APK图标
            try
            {
                string iconPath = aaptParseUtil.GetApkIcon(apkPath);
                Debug.WriteLine("load logo path => " + iconPath);
                iconPictureBox.Load(iconPath);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("load logo error => " + ex.Message);
            }

            // Hash值
            //MessageBox.Show(HashUtil.GetSha256Hash(apkPath));
        }

        private void InitAdbServer()
        {
            ThreadPool.QueueUserWorkItem(CMDUtil.StartAdbServer);
        }


        /* ************************************检测Apk状态 START*************************************************/
        /// <summary>
        /// 检测Apk是否为正常
        /// </summary>
        /// <returns></returns>
        private void CheckApkSafety(object obj)
        {
            // 根据配置是否开启apk检测
            if (!PreferenceUtil.Instance.GetScanBadApk())
            {
                return;
            }
            BadApkDelegate callback = obj as BadApkDelegate;
            try
            {
                bool isBad = CommonUtil.IsBadApk(aaptParseUtil.GetPackageName(), HashUtil.GetSha256Hash(apkPath));
                Console.WriteLine("[InstallFormPro][CheckApkSafety] isBad = " + isBad);
                callback(isBad);
            }
            catch (Exception ex)
            {
                Console.WriteLine("[InstallFormPro][CheckApkSafety] error => " + ex.Message);
                callback(false);
            }
        }

        /// <summary>
        /// Apk状态检测完成
        /// </summary>
        /// <param name="isBadApk"></param>
        private void CheckApkSafetyComplete(bool isBadApk)
        {
            if (this.IsDisposed)
            {
                return;
            }
            this.Invoke(new MethodInvoker(delegate()
            {
                badApkPictureBox.Visible = true;
                if (isBadApk)
                {
                    badApkPictureBox.Image = Properties.Resources.bad_apk;
                }
                else
                {
                    badApkPictureBox.Image = Properties.Resources.bad_apk_safety;
                }
            }));
        }

        /* ************************************检测Apk状态 E N D*************************************************/



        /// <summary>
        /// 获取APK大小
        /// 如果文件大小是0-1024B 以内的   显示以B为单位
        /// 如果文件大小是1KB-1024KB之间的 显示以KB为单位
        /// 如果文件大小是1M-1024M之间的   显示以M为单位
        /// 如果文件大小是1024M以上的      显示以GB为单位
        /// <returns></returns>
        private string GetApkSpace()
        {
            string result = LangUtil.Instance.GetAppUnknown();
            FileStream file = null;
            try
            {
                file = File.Open(apkPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete);
                long space = file.Length;

                if (space < 1024)
                    result = string.Format("{0:F}", space) + " B";
                else if (space > 1024 && space <= Math.Pow(1024, 2))
                    result = string.Format("{0:F}", (space / 1024.0)) + " KB";
                else if (space > Math.Pow(1024, 2) && space <= Math.Pow(1024, 3))
                    result = string.Format("{0:F}", (space / 1024.0 / 1024.0)) + " MB";
                else
                    result = string.Format("{0:F}", (space / 1024.0 / 1024.0 / 1024.0)) + " GB";
            }
            catch (Exception ex)
            {
                Debug.WriteLine("[GetApkSpace Error] " + ex.Message);
            }
            finally
            {
                if (file != null)
                {
                    file.Close();
                }
            }

            return result;
        }

        /// <summary>
        /// 安装点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void installButton_Click(object sender, EventArgs e)
        {
            extraCommand = "";

            string adbStartServerPattern = "\\*[\\w:; ]*";

            // 开启adb服务和查找设备列表分开执行
            CMDUtil.StartAdbServer(1);
            string cmdRunResult = CMDUtil.ExecCMD("adb.exe", "devices").Trim();
            //deviceResult = deviceResult.Replace("List of devices attached", "")
            //.Replace("* daemon not running. starting it", "")
            //.Replace("* daemon not running; starting now at tcp:5037", "")
            //.Replace("* daemon started successfully *", "")
            //.Trim();
            //cmdRunResult = Regex.Replace(cmdRunResult, adbStartServerPattern, "").Trim();
            string[] splitCmdRunResult = Regex.Split(cmdRunResult, "List of devices attached");
            Console.WriteLine("[InstallFormPro][installButton_Click][cmdRunResult] " + cmdRunResult);
            if (splitCmdRunResult.Length != 2)
            {
                MessageBox.Show("Error:" + cmdRunResult);
                return;
            }
            Console.WriteLine("[InstallFormPro][installButton_Click] exist devices :" + splitCmdRunResult[1].Trim());
            string deviceResult = splitCmdRunResult[1].Trim();
            //MessageBox.Show(deviceResult);
            Debug.WriteLine("[InstallFormPro][installButton_Click] deviceResult = " + deviceResult);
            if (string.IsNullOrEmpty(deviceResult))
            {
                MessageBox.Show(LangUtil.Instance.GetNoAnyAndroidDevice());
                return;
            }
            string[] devices = deviceResult.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            // 1.只存在一台设备
            if (devices != null && devices.Length == 1)
            {
                CmdCallbackDelegate installCallback = InstallApkComplete;

                installButton.Enabled = false;
                installButton.Text = LangUtil.Instance.GetAppInstalling();
                installProgressBar.Visible = true;
                extraCommand = "";

                //CMDUtil.ExecCMD("adb.exe", "install " + apkPath);
                //ThreadStart ts = new ThreadStart(InstallApkCMD);

                Thread thread = new Thread(InstallApkCMD);
                thread.Start(installCallback);

                //MessageBox.Show(result);
            }
            else if (devices != null && devices.Length > 1)
            {
                Console.WriteLine("[many devices]" + devices[0] + "....." + devices[1]);
                //2. 存在两台及以上的设备
                List<string> devicesList = new List<string>();
                foreach (string device in devices)
                {
                    //Debug.WriteLine(device);

                    string[] deviceNames = device.Split('\t');
                    //Debug.WriteLine(deviceNames.Length);
                    if (deviceNames.Length == 2)
                    {

                        devicesList.Add(deviceNames[0]);
                    }
                }



                using (DeviceSelectForm deviceSelectForm = new DeviceSelectForm(devicesList))
                {
                    //MessageBox.Show(deviceSelectForm.ShowDialog() + "");
                    //Console.WriteLine("....." + deviceSelectForm.ShowDialog());
                    if (deviceSelectForm.ShowDialog() == DialogResult.Cancel)
                    {

                        if (string.IsNullOrEmpty(deviceSelectForm.resultDevice)) return;

                        // 安装选择的设备
                        CmdCallbackDelegate installCallback = InstallApkComplete;

                        installButton.Enabled = false;
                        installButton.Text = LangUtil.Instance.GetAppInstalling();
                        installProgressBar.Visible = true;
                        extraCommand = "-s " + deviceSelectForm.resultDevice + " ";

                        Debug.Write("extraCommand => " + extraCommand);

                        //CMDUtil.ExecCMD("adb.exe", "install " + apkPath);
                        //ThreadStart ts = new ThreadStart(InstallApkCMD);

                        Thread thread = new Thread(InstallApkCMD);
                        thread.Start(installCallback);
                    }
                }

            }
            else
            {
                // 3. 其它情况
                MessageBox.Show(deviceResult);
            }
            //Console.WriteLine(devices[0]);

            //CMDUtil.ExecCMD("adb.exe", "install " + apkPath);
        }

        /// <summary>
        /// 执行安装APK的命令
        /// </summary>
        /// <param name="obj"></param>
        private void InstallApkCMD(object obj)
        {
            CmdCallbackDelegate callback = obj as CmdCallbackDelegate;
            string installCommand = PreferenceUtil.Instance.GetInstallMethodCommand();
            string result = CMDUtil.ExecCMD("adb.exe", extraCommand + "install " + installCommand + " \"" + apkPath + "\"");
            Debug.WriteLine("[InstallFormPro][InstallApkCMD] command => " + result);
            callback(result);
        }

        ///// <summary>
        ///// 执行安装APK的命令
        ///// </summary>
        ///// <param name="obj"></param>
        //private void InstallApkCMDWithDevice(object obj)
        //{
        //    CmdCallbackDelegate callback = obj as CmdCallbackDelegate;
        //    string result = CMDUtil.ExecCMD("adb.exe", "install device" + apkPath);
        //    callback(result);
        //}

        /// <summary>
        /// 安装完成
        /// </summary>
        /// <param name="result"></param>
        private void InstallApkComplete(string result)
        {

            this.Invoke(new MethodInvoker(delegate()
            {
                installButton.Enabled = true;
                installButton.Text = LangUtil.Instance.GetAppInstall();
                installProgressBar.Visible = false;

                if (!string.IsNullOrEmpty(result) && result.Replace("Performing Streamed Install", "").Trim() == "Success")
                {
                    if (PreferenceUtil.Instance.IsCloseAfterInstalled())
                    {
                        // 关闭窗口     
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(LangUtil.Instance.GetAppInstallSuccess());
                    }
                }
                else if (!string.IsNullOrEmpty(result) && result.Contains("[INSTALL_FAILED_VERSION_DOWNGRADE]"))
                {
                    MessageBox.Show(LangUtil.Instance.GetAppInstallFailedDowngrade());
                }
                else
                {
                    MessageBox.Show(LangUtil.Instance.GetAppInstallFailed() + result);
                }
            }));
        }

        /// <summary>
        /// 查看更多点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void moreLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PermissionForm pf = new PermissionForm(permissionList);
            pf.Show();
        }

        /// <summary>
        /// 点击设置按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settingButton_Click(object sender, EventArgs e)
        {
            new SettingForm().Show();
        }

        /// <summary>
        /// 初始化语言
        /// </summary>
        private void InitLanguage()
        {
            this.Text = LangUtil.Instance.GetInstallFromTitle();
            moreLinkLabel.Text = LangUtil.Instance.GetViewMorePermissions();
            installButton.Text = LangUtil.Instance.GetAppInstall();
        }

    }
}
