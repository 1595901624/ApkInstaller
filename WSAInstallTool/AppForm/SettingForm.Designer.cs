namespace WSAInstallTool.AppForm
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.settingTabControl = new System.Windows.Forms.TabControl();
            this.adbTabPage = new System.Windows.Forms.TabPage();
            this.afterInstalledCloseCheckBox = new System.Windows.Forms.CheckBox();
            this.installMethodPanel = new System.Windows.Forms.Panel();
            this.installMethodLabel = new System.Windows.Forms.Label();
            this.degradedOverlayRadioButton = new System.Windows.Forms.RadioButton();
            this.overlayRadioButton = new System.Windows.Forms.RadioButton();
            this.languageTabPage = new System.Windows.Forms.TabPage();
            this.selectLanguageTipLabel = new System.Windows.Forms.Label();
            this.selectLanguageComboBox = new System.Windows.Forms.ComboBox();
            this.selectLanguageLabel = new System.Windows.Forms.Label();
            this.experimentalFunctionTabPage = new System.Windows.Forms.TabPage();
            this.maliciousApkTipLabel = new System.Windows.Forms.Label();
            this.badApkCheckBox = new System.Windows.Forms.CheckBox();
            this.tipLabel = new System.Windows.Forms.Label();
            this.professionalCheckBox = new System.Windows.Forms.CheckBox();
            this.settingTabControl.SuspendLayout();
            this.adbTabPage.SuspendLayout();
            this.installMethodPanel.SuspendLayout();
            this.languageTabPage.SuspendLayout();
            this.experimentalFunctionTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingTabControl
            // 
            this.settingTabControl.Controls.Add(this.adbTabPage);
            this.settingTabControl.Controls.Add(this.languageTabPage);
            this.settingTabControl.Controls.Add(this.experimentalFunctionTabPage);
            this.settingTabControl.Location = new System.Drawing.Point(20, 18);
            this.settingTabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.settingTabControl.Name = "settingTabControl";
            this.settingTabControl.SelectedIndex = 0;
            this.settingTabControl.Size = new System.Drawing.Size(831, 446);
            this.settingTabControl.TabIndex = 0;
            // 
            // adbTabPage
            // 
            this.adbTabPage.Controls.Add(this.afterInstalledCloseCheckBox);
            this.adbTabPage.Controls.Add(this.installMethodPanel);
            this.adbTabPage.Location = new System.Drawing.Point(4, 28);
            this.adbTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adbTabPage.Name = "adbTabPage";
            this.adbTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adbTabPage.Size = new System.Drawing.Size(823, 414);
            this.adbTabPage.TabIndex = 0;
            this.adbTabPage.Text = "安装设置";
            this.adbTabPage.UseVisualStyleBackColor = true;
            // 
            // afterInstalledCloseCheckBox
            // 
            this.afterInstalledCloseCheckBox.AutoSize = true;
            this.afterInstalledCloseCheckBox.Location = new System.Drawing.Point(21, 24);
            this.afterInstalledCloseCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.afterInstalledCloseCheckBox.Name = "afterInstalledCloseCheckBox";
            this.afterInstalledCloseCheckBox.Size = new System.Drawing.Size(232, 22);
            this.afterInstalledCloseCheckBox.TabIndex = 4;
            this.afterInstalledCloseCheckBox.Text = "安装完成后自动关闭窗口";
            this.afterInstalledCloseCheckBox.UseVisualStyleBackColor = true;
            this.afterInstalledCloseCheckBox.CheckedChanged += new System.EventHandler(this.afterInstalledCloseCheckBox_CheckedChanged);
            // 
            // installMethodPanel
            // 
            this.installMethodPanel.Controls.Add(this.installMethodLabel);
            this.installMethodPanel.Controls.Add(this.degradedOverlayRadioButton);
            this.installMethodPanel.Controls.Add(this.overlayRadioButton);
            this.installMethodPanel.Location = new System.Drawing.Point(14, 72);
            this.installMethodPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.installMethodPanel.Name = "installMethodPanel";
            this.installMethodPanel.Size = new System.Drawing.Size(801, 72);
            this.installMethodPanel.TabIndex = 3;
            // 
            // installMethodLabel
            // 
            this.installMethodLabel.AutoSize = true;
            this.installMethodLabel.Location = new System.Drawing.Point(4, 27);
            this.installMethodLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.installMethodLabel.Name = "installMethodLabel";
            this.installMethodLabel.Size = new System.Drawing.Size(98, 18);
            this.installMethodLabel.TabIndex = 2;
            this.installMethodLabel.Text = "安装方式：";
            // 
            // degradedOverlayRadioButton
            // 
            this.degradedOverlayRadioButton.AutoSize = true;
            this.degradedOverlayRadioButton.Location = new System.Drawing.Point(454, 21);
            this.degradedOverlayRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.degradedOverlayRadioButton.Name = "degradedOverlayRadioButton";
            this.degradedOverlayRadioButton.Size = new System.Drawing.Size(141, 22);
            this.degradedOverlayRadioButton.TabIndex = 1;
            this.degradedOverlayRadioButton.TabStop = true;
            this.degradedOverlayRadioButton.Text = "降级覆盖安装";
            this.degradedOverlayRadioButton.UseVisualStyleBackColor = true;
            this.degradedOverlayRadioButton.CheckedChanged += new System.EventHandler(this.degradedOverlayRadioButton_CheckedChanged);
            // 
            // overlayRadioButton
            // 
            this.overlayRadioButton.AutoSize = true;
            this.overlayRadioButton.Location = new System.Drawing.Point(201, 24);
            this.overlayRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.overlayRadioButton.Name = "overlayRadioButton";
            this.overlayRadioButton.Size = new System.Drawing.Size(105, 22);
            this.overlayRadioButton.TabIndex = 0;
            this.overlayRadioButton.TabStop = true;
            this.overlayRadioButton.Text = "覆盖安装";
            this.overlayRadioButton.UseVisualStyleBackColor = true;
            this.overlayRadioButton.CheckedChanged += new System.EventHandler(this.overlayRadioButton_CheckedChanged);
            // 
            // languageTabPage
            // 
            this.languageTabPage.Controls.Add(this.selectLanguageTipLabel);
            this.languageTabPage.Controls.Add(this.selectLanguageComboBox);
            this.languageTabPage.Controls.Add(this.selectLanguageLabel);
            this.languageTabPage.Location = new System.Drawing.Point(4, 28);
            this.languageTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.languageTabPage.Name = "languageTabPage";
            this.languageTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.languageTabPage.Size = new System.Drawing.Size(823, 414);
            this.languageTabPage.TabIndex = 1;
            this.languageTabPage.Text = "语言设置";
            this.languageTabPage.UseVisualStyleBackColor = true;
            // 
            // selectLanguageTipLabel
            // 
            this.selectLanguageTipLabel.AutoSize = true;
            this.selectLanguageTipLabel.Location = new System.Drawing.Point(30, 24);
            this.selectLanguageTipLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectLanguageTipLabel.Name = "selectLanguageTipLabel";
            this.selectLanguageTipLabel.Size = new System.Drawing.Size(260, 18);
            this.selectLanguageTipLabel.TabIndex = 2;
            this.selectLanguageTipLabel.Text = "注：语言选择后需要下一次生效";
            // 
            // selectLanguageComboBox
            // 
            this.selectLanguageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectLanguageComboBox.FormattingEnabled = true;
            this.selectLanguageComboBox.Location = new System.Drawing.Point(33, 111);
            this.selectLanguageComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectLanguageComboBox.Name = "selectLanguageComboBox";
            this.selectLanguageComboBox.Size = new System.Drawing.Size(306, 26);
            this.selectLanguageComboBox.TabIndex = 1;
            this.selectLanguageComboBox.SelectedIndexChanged += new System.EventHandler(this.selectLanguageComboBox_SelectedIndexChanged);
            // 
            // selectLanguageLabel
            // 
            this.selectLanguageLabel.AutoSize = true;
            this.selectLanguageLabel.Location = new System.Drawing.Point(30, 72);
            this.selectLanguageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectLanguageLabel.Name = "selectLanguageLabel";
            this.selectLanguageLabel.Size = new System.Drawing.Size(80, 18);
            this.selectLanguageLabel.TabIndex = 0;
            this.selectLanguageLabel.Text = "选择语言";
            // 
            // experimentalFunctionTabPage
            // 
            this.experimentalFunctionTabPage.Controls.Add(this.professionalCheckBox);
            this.experimentalFunctionTabPage.Controls.Add(this.maliciousApkTipLabel);
            this.experimentalFunctionTabPage.Controls.Add(this.badApkCheckBox);
            this.experimentalFunctionTabPage.Location = new System.Drawing.Point(4, 28);
            this.experimentalFunctionTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.experimentalFunctionTabPage.Name = "experimentalFunctionTabPage";
            this.experimentalFunctionTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.experimentalFunctionTabPage.Size = new System.Drawing.Size(823, 414);
            this.experimentalFunctionTabPage.TabIndex = 2;
            this.experimentalFunctionTabPage.Text = "实验室功能";
            this.experimentalFunctionTabPage.UseVisualStyleBackColor = true;
            // 
            // maliciousApkTipLabel
            // 
            this.maliciousApkTipLabel.Location = new System.Drawing.Point(40, 146);
            this.maliciousApkTipLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maliciousApkTipLabel.Name = "maliciousApkTipLabel";
            this.maliciousApkTipLabel.Size = new System.Drawing.Size(710, 152);
            this.maliciousApkTipLabel.TabIndex = 1;
            this.maliciousApkTipLabel.Text = "注：恶意软件识别功能需要电脑连接网络，该功能目前尚处于实验性阶段，识别率较低，甚至出现误报。当然随着用户使用率的提高，识别率会逐渐提高。由于该功能需要使用平台去检" +
    "测，为缓解服务器压力，默认关闭此功能。";
            // 
            // badApkCheckBox
            // 
            this.badApkCheckBox.AutoSize = true;
            this.badApkCheckBox.Location = new System.Drawing.Point(43, 86);
            this.badApkCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.badApkCheckBox.Name = "badApkCheckBox";
            this.badApkCheckBox.Size = new System.Drawing.Size(214, 22);
            this.badApkCheckBox.TabIndex = 0;
            this.badApkCheckBox.Text = "启用恶意软件识别功能";
            this.badApkCheckBox.UseVisualStyleBackColor = true;
            this.badApkCheckBox.CheckedChanged += new System.EventHandler(this.badApkCheckBox_CheckedChanged);
            // 
            // tipLabel
            // 
            this.tipLabel.AutoSize = true;
            this.tipLabel.Location = new System.Drawing.Point(22, 468);
            this.tipLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.Size = new System.Drawing.Size(377, 18);
            this.tipLabel.TabIndex = 1;
            this.tipLabel.Text = "注:该页面下所有的偏好设置都是全局生效的。";
            // 
            // professionalCheckBox
            // 
            this.professionalCheckBox.AutoSize = true;
            this.professionalCheckBox.Location = new System.Drawing.Point(43, 32);
            this.professionalCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.professionalCheckBox.Name = "professionalCheckBox";
            this.professionalCheckBox.Size = new System.Drawing.Size(142, 22);
            this.professionalCheckBox.TabIndex = 2;
            this.professionalCheckBox.Text = "启用专业模式";
            this.professionalCheckBox.UseVisualStyleBackColor = true;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 506);
            this.Controls.Add(this.tipLabel);
            this.Controls.Add(this.settingTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "偏好设置";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.settingTabControl.ResumeLayout(false);
            this.adbTabPage.ResumeLayout(false);
            this.adbTabPage.PerformLayout();
            this.installMethodPanel.ResumeLayout(false);
            this.installMethodPanel.PerformLayout();
            this.languageTabPage.ResumeLayout(false);
            this.languageTabPage.PerformLayout();
            this.experimentalFunctionTabPage.ResumeLayout(false);
            this.experimentalFunctionTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl settingTabControl;
        private System.Windows.Forms.TabPage adbTabPage;
        private System.Windows.Forms.RadioButton degradedOverlayRadioButton;
        private System.Windows.Forms.RadioButton overlayRadioButton;
        private System.Windows.Forms.Label installMethodLabel;
        private System.Windows.Forms.Panel installMethodPanel;
        private System.Windows.Forms.CheckBox afterInstalledCloseCheckBox;
        private System.Windows.Forms.Label tipLabel;
        private System.Windows.Forms.TabPage languageTabPage;
        private System.Windows.Forms.Label selectLanguageLabel;
        private System.Windows.Forms.ComboBox selectLanguageComboBox;
        private System.Windows.Forms.Label selectLanguageTipLabel;
        private System.Windows.Forms.TabPage experimentalFunctionTabPage;
        private System.Windows.Forms.CheckBox badApkCheckBox;
        private System.Windows.Forms.Label maliciousApkTipLabel;
        private System.Windows.Forms.CheckBox professionalCheckBox;
    }
}