using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSAInstallTool.AppForm;
using WSAInstallTool.Util;

namespace WSAInstallTool
{
    public partial class InstallForm : Form
    {
        private String[] args = null;

        // 额外的设备命令
        private string extraCommand = "";

        private string apkPath = "";

        // 完整的权限列表
        private List<string> permissionList;

        // Cmd 回调委托
        private delegate void CmdCallbackDelegate(string result);

        public InstallForm()
        {
            InitializeComponent();
        }

        public InstallForm(String[] args) 
        {
            this.args = args;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("dir == " + Environment.CurrentDirectory);
            //MessageBox.Show("" + System.Threading.Thread.GetDomain().BaseDirectory);
            apkPath = @"C:\Users\haoyu\Desktop\110_49b6fa118f4a5d9906eb42a86b4d4ebe.apk";
            if (args != null && args.Length > 0)
            {
                apkPath = args[0];
            }
          
            //string apkPath = "C:\\Users\\haoyu\\Desktop\\106_f0c49f2b285b39d89d87a3c5747ea155.apk";

            string result = CMDUtil.ExecCMD("aapt.exe", "dump badging \"" + apkPath + "\"");

            AAPTParseUtil aaptParseUtil = new AAPTParseUtil(result);

            packageNameLabel.Text = "包名：" + aaptParseUtil.GetPackageName();
            versionNameLabel.Text = "版本名称：" + aaptParseUtil.GetVersionName();
            minVersionLabel.Text = "最低支持版本：" + aaptParseUtil.getMinSupportVersion();

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
            permissionLabel.Text = "权限：\n" + permissionStringBuilder.ToString();

            // APP 名称
            appNameLabel.Text = aaptParseUtil.GetAppName();

            // APP 大小
            spaceLabel.Text = "大小：" + GetApkSpace();

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

        }

        /// <summary>
        /// 获取APK大小
        /// 如果文件大小是0-1024B 以内的   显示以B为单位
        /// 如果文件大小是1KB-1024KB之间的 显示以KB为单位
        /// 如果文件大小是1M-1024M之间的   显示以M为单位
        /// 如果文件大小是1024M以上的      显示以GB为单位
        /// <returns></returns>
        private string GetApkSpace()
        {
            string result = "未知";
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

            string deviceResult = CMDUtil.ExecCMD("adb.exe","devices");
            deviceResult = deviceResult.Replace("List of devices attached", "")
                .Replace("* daemon not running. starting it", "")
                .Replace("* daemon started successfully *", "")
                .Trim();
            //MessageBox.Show(deviceResult);
            if (string.IsNullOrEmpty(deviceResult))
            {
                MessageBox.Show("没有检测到任何安卓设备！");
                return;
            }
            string[] devices = deviceResult.Split('\n');
            // 1.只存在一台设备
            if (devices != null && devices.Length == 1)
            {
                CmdCallbackDelegate installCallback = InstallApkComplete;

                installButton.Enabled = false;
                installButton.Text = "安装中...";
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
                //2. 存在两台及以上的设备
                List<string> devicesList = new List<string>();
                foreach (string device in devices)
                {
                    Debug.WriteLine(device);

                    string[] deviceNames = device.Split('\t');
                    Debug.WriteLine(deviceNames.Length);
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
                        installButton.Text = "安装中...";
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
            Debug.WriteLine("[InstallForm][InstallApkCMD] command => " + result);
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

            this.Invoke(new MethodInvoker(delegate() {
                installButton.Enabled = true;
                installButton.Text = "安装";
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
                        MessageBox.Show("安装成功！");
                    }
                }
                else if (!string.IsNullOrEmpty(result) && result.Contains("[INSTALL_FAILED_VERSION_DOWNGRADE]"))
                {
                    MessageBox.Show("安装失败：检测到当前安装版本低于设备中已安装的版本。\n如果需要强制安装，请到设置页开启“降级覆盖安装”！");
                }
                else
                {
                    MessageBox.Show("ERROR: " + result);
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
    }
}
