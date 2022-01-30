using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
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

  
    }
}
