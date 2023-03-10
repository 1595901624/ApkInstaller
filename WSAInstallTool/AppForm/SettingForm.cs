using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSAInstallTool.AppModel;
using WSAInstallTool.Util;

namespace WSAInstallTool.AppForm
{
    public partial class SettingForm : Form
    {
        // 是否已经初始化结束
        private bool inited = false;

        public SettingForm()
        {
            InitializeComponent();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            inited = false;

            InitLanguage();
            InitInstallMethod();
            InitInstallSuccessStatus();
            InitSelectLanguage();
            InitScanApkStatus();
            InitWSAConnect();
            InitWSAConnectIpAddress();
            InitAboutPage();

            inited = true;
        }

        /// <summary>
        /// 初始化安装方式
        /// </summary>
        private void InitInstallMethod()
        {
            if (PreferenceUtil.Instance.GetInstallMethod() == PreferenceUtil.InstallMethod.DEGRADED_OVERLAY)
            {
                degradedOverlayRadioButton.Checked = true;
            }
            else
            {
                overlayRadioButton.Checked = true;
            }
        }

        /// <summary>
        /// 初始化安装完成的开关
        /// </summary>
        private void InitInstallSuccessStatus()
        {
            afterInstalledCloseCheckBox.Checked = PreferenceUtil.Instance.IsCloseAfterInstalled();
        }

        // **************************************************以下是开关监听*********************************************************************//
        private void overlayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (overlayRadioButton.Checked && inited)
            {
                PreferenceUtil.Instance.SetInstallMethod(PreferenceUtil.InstallMethod.OVERLAY);
                Debug.WriteLine("[PreferenceUtil][overlayRadioButton_CheckedChanged] true");
            }
        }

        private void degradedOverlayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (degradedOverlayRadioButton.Checked && inited)
            {
                PreferenceUtil.Instance.SetInstallMethod(PreferenceUtil.InstallMethod.DEGRADED_OVERLAY);
                Debug.WriteLine("[PreferenceUtil][degradedOverlayRadioButton_CheckedChanged] true");
            }
        }

        private void afterInstalledCloseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (inited)
            {
                bool check = afterInstalledCloseCheckBox.Checked;
                Debug.WriteLine("[PreferenceUtil][afterInstalledCloseCheckBox_CheckedChanged] " + check);
                PreferenceUtil.Instance.SetCloseAfterInstalled(check ? 1 : 0);
            }

        }


        private void badApkCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (inited)
            {
                bool check = badApkCheckBox.Checked;
                Debug.WriteLine("[PreferenceUtil][badApkCheckBox_CheckedChanged] " + check);
                PreferenceUtil.Instance.SetScanBadApk(check ? 1 : 0);
            }
        }

        private void InitScanApkStatus()
        {
            bool check = PreferenceUtil.Instance.GetScanBadApk();
            badApkCheckBox.Checked = check;
        }

        private void InitLanguage()
        {
            this.Text = LangUtil.Instance.GetSettingFormTitle();
            // 安装设置
            settingTabControl.TabPages[0].Text = LangUtil.Instance.GetInstallSettingTabTitle();
            afterInstalledCloseCheckBox.Text = LangUtil.Instance.GetAfterInstallSuccessClose();
            installMethodLabel.Text = LangUtil.Instance.GetInstallMethod();
            overlayRadioButton.Text = LangUtil.Instance.GetOverlayInstall();
            degradedOverlayRadioButton.Text = LangUtil.Instance.GetDowngradeOverlayInsall();
            tipLabel.Text = LangUtil.Instance.GetSettingFormBottomTip();

            // 语言设置
            settingTabControl.TabPages[1].Text = LangUtil.Instance.GetLanguageSettingTitle();
            selectLanguageLabel.Text = LangUtil.Instance.GetSelectLanguage();
            selectLanguageTipLabel.Text = LangUtil.Instance.GetSelectLanguageTip();

            // 实验室功能
            settingTabControl.TabPages[2].Text = LangUtil.Instance.GetExperimentalFunction();
            maliciousApkTipLabel.Text = LangUtil.Instance.GetDetectionMaliciousApkTip();
            badApkCheckBox.Text = LangUtil.Instance.GetDetectionMaliciousApk();
        }

        private void selectLanguageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inited)
            {
                var sl = (SupportLanguage)selectLanguageComboBox.SelectedItem;
                Debug.WriteLine("[SettingForm][selectLanguageComboBox_SelectedIndexChanged] select => " + sl.id);

                PreferenceUtil.Instance.SetLanguage(sl.id);
            }
        }


        private void InitSelectLanguage()
        {
            var list = PreferenceUtil.Instance.GetLanguageList();
            selectLanguageComboBox.DataSource = PreferenceUtil.Instance.GetLanguageList();
            selectLanguageComboBox.DisplayMember = "name";
            selectLanguageComboBox.ValueMember = "id";

            int id = PreferenceUtil.Instance.GetLanguage();
            if (id < list.Count)
            {
                selectLanguageComboBox.SelectedIndex = id;
            }

        }

        /// <summary>
        /// 无线连接 / WSA 设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void connectCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (inited)
            {
                bool check = connectCheckBox.Checked;
                Debug.WriteLine("[PreferenceUtil][connectCheckBox_CheckedChanged] " + check);
                PreferenceUtil.Instance.SetWSAConnect(check ? 1 : 0);
            }
        }

        private void InitWSAConnect()
        {
            bool check = PreferenceUtil.Instance.GetWSAConnect();
            connectCheckBox.Checked = check;
        }

        /// <summary>
        /// ip地址改变就保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void connectTextBox_TextChanged(object sender, EventArgs e)
        {
            // 127.0.0.1:58526
            // 随时保存
            if (!inited)
            {
                return;
            }
            PreferenceUtil.Instance.SetWSAConnectIpAddress(connectTextBox.Text.ToString().Trim());
        }

        private void InitWSAConnectIpAddress()
        {
            string ip = PreferenceUtil.Instance.GetWSAConnectIpAddress();
            connectTextBox.Text = ip;
        }

        /// <summary>
        ///  初始化关于页面
        /// </summary>
        private void InitAboutPage()
        {
            versionLabel.Text = String.Format("版本号： {0}", Assembly.GetExecutingAssembly().GetName().Version.ToString());
            authorLabel.Text = "作者：我是小学生";
            githubLabel.Text = "Github：";
            githubLinkLabel.Text = "https://github.com/1595901624/ApkInstaller";
            giteeLinkLabel.Text = "https://gitee.com/haoyu3/wsainstall-tool/";
            StringBuilder sb = new StringBuilder();
            sb.Append("感谢开源软件：").Append("\n")
                .Append("kkguo —— ApkShellExt2").Append("\n")
                .Append("我是小学生 —— ApkShellExt2 v3.0.0").Append("\n")
                .Append("Google —— AAPT").Append("\n")
                .Append("Google —— ADB Shell").Append("\n");
            thankLabel.Text = sb.ToString();
        }

        private void githubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/1595901624/ApkInstaller");
        }

        private void giteeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://gitee.com/haoyu3/wsainstall-tool/");
        }
    }
}
