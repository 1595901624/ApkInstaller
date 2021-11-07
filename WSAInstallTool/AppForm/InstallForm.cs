using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            apkPath = "C:\\Users\\haoyu\\Desktop\\106_f0c49f2b285b39d89d87a3c5747ea155.apk";
            if (args != null && args.Length > 0)
            {
                apkPath = args[0];
            }
          
            //string apkPath = "C:\\Users\\haoyu\\Desktop\\106_f0c49f2b285b39d89d87a3c5747ea155.apk";

            string result = CMDUtil.ExecCMD("aapt.exe", "dump badging " + apkPath);

            AAPTParseUtil aaptParseUtil = new AAPTParseUtil(result);

            packageNameLabel.Text = "包名：" + aaptParseUtil.GetPackageName();
            versionNameLabel.Text = "版本名称：" + aaptParseUtil.GetVersionName();

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

            // 获取APK图标
            try
            {
                string iconPath = aaptParseUtil.GetApkIcon(apkPath);
                iconPictureBox.Load(iconPath);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("load logo error => " + ex.Message);
            }

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
            string result = CMDUtil.ExecCMD("adb.exe", extraCommand + "install -r " + apkPath);
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
                    MessageBox.Show("安装成功！");
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
    }
}
