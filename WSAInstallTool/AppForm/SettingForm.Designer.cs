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
            this.connectGroupBox = new System.Windows.Forms.GroupBox();
            this.connectCheckBox = new System.Windows.Forms.CheckBox();
            this.connectTextBox = new System.Windows.Forms.TextBox();
            this.installMethodGroupBox = new System.Windows.Forms.GroupBox();
            this.installMethodLabel = new System.Windows.Forms.Label();
            this.overlayRadioButton = new System.Windows.Forms.RadioButton();
            this.degradedOverlayRadioButton = new System.Windows.Forms.RadioButton();
            this.afterInstalledCloseCheckBox = new System.Windows.Forms.CheckBox();
            this.languageTabPage = new System.Windows.Forms.TabPage();
            this.selectLanguageTipLabel = new System.Windows.Forms.Label();
            this.selectLanguageComboBox = new System.Windows.Forms.ComboBox();
            this.selectLanguageLabel = new System.Windows.Forms.Label();
            this.experimentalFunctionTabPage = new System.Windows.Forms.TabPage();
            this.professionalCheckBox = new System.Windows.Forms.CheckBox();
            this.maliciousApkTipLabel = new System.Windows.Forms.Label();
            this.badApkCheckBox = new System.Windows.Forms.CheckBox();
            this.aboutTabPage = new System.Windows.Forms.TabPage();
            this.wechatPictureBox = new System.Windows.Forms.PictureBox();
            this.alipayPicctureBox = new System.Windows.Forms.PictureBox();
            this.giteeLinkLabel = new System.Windows.Forms.LinkLabel();
            this.giteeLabel = new System.Windows.Forms.Label();
            this.githubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.githubLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.tipLabel = new System.Windows.Forms.Label();
            this.alipayLabel = new System.Windows.Forms.Label();
            this.wechatLabel = new System.Windows.Forms.Label();
            this.donateLabel = new System.Windows.Forms.Label();
            this.thankLabel = new System.Windows.Forms.Label();
            this.settingTabControl.SuspendLayout();
            this.adbTabPage.SuspendLayout();
            this.connectGroupBox.SuspendLayout();
            this.installMethodGroupBox.SuspendLayout();
            this.languageTabPage.SuspendLayout();
            this.experimentalFunctionTabPage.SuspendLayout();
            this.aboutTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wechatPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alipayPicctureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // settingTabControl
            // 
            this.settingTabControl.Controls.Add(this.adbTabPage);
            this.settingTabControl.Controls.Add(this.languageTabPage);
            this.settingTabControl.Controls.Add(this.experimentalFunctionTabPage);
            this.settingTabControl.Controls.Add(this.aboutTabPage);
            this.settingTabControl.Location = new System.Drawing.Point(26, 24);
            this.settingTabControl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.settingTabControl.Name = "settingTabControl";
            this.settingTabControl.SelectedIndex = 0;
            this.settingTabControl.Size = new System.Drawing.Size(1108, 611);
            this.settingTabControl.TabIndex = 0;
            // 
            // adbTabPage
            // 
            this.adbTabPage.Controls.Add(this.connectGroupBox);
            this.adbTabPage.Controls.Add(this.installMethodGroupBox);
            this.adbTabPage.Controls.Add(this.afterInstalledCloseCheckBox);
            this.adbTabPage.Location = new System.Drawing.Point(8, 39);
            this.adbTabPage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.adbTabPage.Name = "adbTabPage";
            this.adbTabPage.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.adbTabPage.Size = new System.Drawing.Size(1092, 547);
            this.adbTabPage.TabIndex = 0;
            this.adbTabPage.Text = "安装设置";
            this.adbTabPage.UseVisualStyleBackColor = true;
            // 
            // connectGroupBox
            // 
            this.connectGroupBox.Controls.Add(this.connectCheckBox);
            this.connectGroupBox.Controls.Add(this.connectTextBox);
            this.connectGroupBox.Location = new System.Drawing.Point(28, 272);
            this.connectGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.connectGroupBox.Name = "connectGroupBox";
            this.connectGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.connectGroupBox.Size = new System.Drawing.Size(1032, 128);
            this.connectGroupBox.TabIndex = 8;
            this.connectGroupBox.TabStop = false;
            this.connectGroupBox.Text = "Windows Subsystem Android/无线调试设置";
            // 
            // connectCheckBox
            // 
            this.connectCheckBox.AutoSize = true;
            this.connectCheckBox.Location = new System.Drawing.Point(28, 62);
            this.connectCheckBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.connectCheckBox.Name = "connectCheckBox";
            this.connectCheckBox.Size = new System.Drawing.Size(594, 28);
            this.connectCheckBox.TabIndex = 9;
            this.connectCheckBox.Text = "安装前主动连接指定无线设备或者WSA(默认连接WSA)";
            this.connectCheckBox.UseVisualStyleBackColor = true;
            this.connectCheckBox.CheckedChanged += new System.EventHandler(this.connectCheckBox_CheckedChanged);
            // 
            // connectTextBox
            // 
            this.connectTextBox.Location = new System.Drawing.Point(632, 60);
            this.connectTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.connectTextBox.Name = "connectTextBox";
            this.connectTextBox.Size = new System.Drawing.Size(308, 35);
            this.connectTextBox.TabIndex = 5;
            this.connectTextBox.Text = "127.0.0.1:58526";
            this.connectTextBox.TextChanged += new System.EventHandler(this.connectTextBox_TextChanged);
            // 
            // installMethodGroupBox
            // 
            this.installMethodGroupBox.Controls.Add(this.installMethodLabel);
            this.installMethodGroupBox.Controls.Add(this.overlayRadioButton);
            this.installMethodGroupBox.Controls.Add(this.degradedOverlayRadioButton);
            this.installMethodGroupBox.Location = new System.Drawing.Point(26, 100);
            this.installMethodGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.installMethodGroupBox.Name = "installMethodGroupBox";
            this.installMethodGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.installMethodGroupBox.Size = new System.Drawing.Size(1032, 128);
            this.installMethodGroupBox.TabIndex = 7;
            this.installMethodGroupBox.TabStop = false;
            this.installMethodGroupBox.Text = "          ";
            // 
            // installMethodLabel
            // 
            this.installMethodLabel.AutoSize = true;
            this.installMethodLabel.Location = new System.Drawing.Point(8, 0);
            this.installMethodLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.installMethodLabel.Name = "installMethodLabel";
            this.installMethodLabel.Size = new System.Drawing.Size(106, 24);
            this.installMethodLabel.TabIndex = 2;
            this.installMethodLabel.Text = "安装方式";
            // 
            // overlayRadioButton
            // 
            this.overlayRadioButton.AutoSize = true;
            this.overlayRadioButton.Location = new System.Drawing.Point(30, 64);
            this.overlayRadioButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.overlayRadioButton.Name = "overlayRadioButton";
            this.overlayRadioButton.Size = new System.Drawing.Size(137, 28);
            this.overlayRadioButton.TabIndex = 0;
            this.overlayRadioButton.TabStop = true;
            this.overlayRadioButton.Text = "覆盖安装";
            this.overlayRadioButton.UseVisualStyleBackColor = true;
            this.overlayRadioButton.CheckedChanged += new System.EventHandler(this.overlayRadioButton_CheckedChanged);
            // 
            // degradedOverlayRadioButton
            // 
            this.degradedOverlayRadioButton.AutoSize = true;
            this.degradedOverlayRadioButton.Location = new System.Drawing.Point(234, 64);
            this.degradedOverlayRadioButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.degradedOverlayRadioButton.Name = "degradedOverlayRadioButton";
            this.degradedOverlayRadioButton.Size = new System.Drawing.Size(185, 28);
            this.degradedOverlayRadioButton.TabIndex = 1;
            this.degradedOverlayRadioButton.TabStop = true;
            this.degradedOverlayRadioButton.Text = "降级覆盖安装";
            this.degradedOverlayRadioButton.UseVisualStyleBackColor = true;
            this.degradedOverlayRadioButton.CheckedChanged += new System.EventHandler(this.degradedOverlayRadioButton_CheckedChanged);
            // 
            // afterInstalledCloseCheckBox
            // 
            this.afterInstalledCloseCheckBox.AutoSize = true;
            this.afterInstalledCloseCheckBox.Location = new System.Drawing.Point(28, 32);
            this.afterInstalledCloseCheckBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.afterInstalledCloseCheckBox.Name = "afterInstalledCloseCheckBox";
            this.afterInstalledCloseCheckBox.Size = new System.Drawing.Size(306, 28);
            this.afterInstalledCloseCheckBox.TabIndex = 4;
            this.afterInstalledCloseCheckBox.Text = "安装完成后自动关闭窗口";
            this.afterInstalledCloseCheckBox.UseVisualStyleBackColor = true;
            this.afterInstalledCloseCheckBox.CheckedChanged += new System.EventHandler(this.afterInstalledCloseCheckBox_CheckedChanged);
            // 
            // languageTabPage
            // 
            this.languageTabPage.Controls.Add(this.selectLanguageTipLabel);
            this.languageTabPage.Controls.Add(this.selectLanguageComboBox);
            this.languageTabPage.Controls.Add(this.selectLanguageLabel);
            this.languageTabPage.Location = new System.Drawing.Point(8, 39);
            this.languageTabPage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.languageTabPage.Name = "languageTabPage";
            this.languageTabPage.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.languageTabPage.Size = new System.Drawing.Size(1092, 547);
            this.languageTabPage.TabIndex = 1;
            this.languageTabPage.Text = "语言设置";
            this.languageTabPage.UseVisualStyleBackColor = true;
            // 
            // selectLanguageTipLabel
            // 
            this.selectLanguageTipLabel.AutoSize = true;
            this.selectLanguageTipLabel.Location = new System.Drawing.Point(40, 32);
            this.selectLanguageTipLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.selectLanguageTipLabel.Name = "selectLanguageTipLabel";
            this.selectLanguageTipLabel.Size = new System.Drawing.Size(346, 24);
            this.selectLanguageTipLabel.TabIndex = 2;
            this.selectLanguageTipLabel.Text = "注：语言选择后需要下一次生效";
            // 
            // selectLanguageComboBox
            // 
            this.selectLanguageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectLanguageComboBox.FormattingEnabled = true;
            this.selectLanguageComboBox.Location = new System.Drawing.Point(44, 148);
            this.selectLanguageComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.selectLanguageComboBox.Name = "selectLanguageComboBox";
            this.selectLanguageComboBox.Size = new System.Drawing.Size(406, 32);
            this.selectLanguageComboBox.TabIndex = 1;
            this.selectLanguageComboBox.SelectedIndexChanged += new System.EventHandler(this.selectLanguageComboBox_SelectedIndexChanged);
            // 
            // selectLanguageLabel
            // 
            this.selectLanguageLabel.AutoSize = true;
            this.selectLanguageLabel.Location = new System.Drawing.Point(40, 96);
            this.selectLanguageLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.selectLanguageLabel.Name = "selectLanguageLabel";
            this.selectLanguageLabel.Size = new System.Drawing.Size(106, 24);
            this.selectLanguageLabel.TabIndex = 0;
            this.selectLanguageLabel.Text = "选择语言";
            // 
            // experimentalFunctionTabPage
            // 
            this.experimentalFunctionTabPage.Controls.Add(this.professionalCheckBox);
            this.experimentalFunctionTabPage.Controls.Add(this.maliciousApkTipLabel);
            this.experimentalFunctionTabPage.Controls.Add(this.badApkCheckBox);
            this.experimentalFunctionTabPage.Location = new System.Drawing.Point(8, 39);
            this.experimentalFunctionTabPage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.experimentalFunctionTabPage.Name = "experimentalFunctionTabPage";
            this.experimentalFunctionTabPage.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.experimentalFunctionTabPage.Size = new System.Drawing.Size(1092, 547);
            this.experimentalFunctionTabPage.TabIndex = 2;
            this.experimentalFunctionTabPage.Text = "实验室功能";
            this.experimentalFunctionTabPage.UseVisualStyleBackColor = true;
            // 
            // professionalCheckBox
            // 
            this.professionalCheckBox.AutoSize = true;
            this.professionalCheckBox.Location = new System.Drawing.Point(44, 32);
            this.professionalCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.professionalCheckBox.Name = "professionalCheckBox";
            this.professionalCheckBox.Size = new System.Drawing.Size(186, 28);
            this.professionalCheckBox.TabIndex = 2;
            this.professionalCheckBox.Text = "启用专业模式";
            this.professionalCheckBox.UseVisualStyleBackColor = true;
            this.professionalCheckBox.Visible = false;
            // 
            // maliciousApkTipLabel
            // 
            this.maliciousApkTipLabel.Location = new System.Drawing.Point(56, 156);
            this.maliciousApkTipLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.maliciousApkTipLabel.Name = "maliciousApkTipLabel";
            this.maliciousApkTipLabel.Size = new System.Drawing.Size(946, 200);
            this.maliciousApkTipLabel.TabIndex = 1;
            this.maliciousApkTipLabel.Text = "注：恶意软件识别功能需要电脑连接网络，该功能目前尚处于实验性阶段，识别率较低，甚至出现误报。当然随着用户使用率的提高，识别率会逐渐提高。由于该功能需要使用平台去检" +
    "测，为缓解服务器压力，默认关闭此功能。";
            // 
            // badApkCheckBox
            // 
            this.badApkCheckBox.AutoSize = true;
            this.badApkCheckBox.Location = new System.Drawing.Point(44, 88);
            this.badApkCheckBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.badApkCheckBox.Name = "badApkCheckBox";
            this.badApkCheckBox.Size = new System.Drawing.Size(282, 28);
            this.badApkCheckBox.TabIndex = 0;
            this.badApkCheckBox.Text = "启用恶意软件识别功能";
            this.badApkCheckBox.UseVisualStyleBackColor = true;
            this.badApkCheckBox.CheckedChanged += new System.EventHandler(this.badApkCheckBox_CheckedChanged);
            // 
            // aboutTabPage
            // 
            this.aboutTabPage.Controls.Add(this.thankLabel);
            this.aboutTabPage.Controls.Add(this.donateLabel);
            this.aboutTabPage.Controls.Add(this.wechatLabel);
            this.aboutTabPage.Controls.Add(this.alipayLabel);
            this.aboutTabPage.Controls.Add(this.wechatPictureBox);
            this.aboutTabPage.Controls.Add(this.alipayPicctureBox);
            this.aboutTabPage.Controls.Add(this.giteeLinkLabel);
            this.aboutTabPage.Controls.Add(this.giteeLabel);
            this.aboutTabPage.Controls.Add(this.githubLinkLabel);
            this.aboutTabPage.Controls.Add(this.githubLabel);
            this.aboutTabPage.Controls.Add(this.authorLabel);
            this.aboutTabPage.Controls.Add(this.versionLabel);
            this.aboutTabPage.Location = new System.Drawing.Point(8, 39);
            this.aboutTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aboutTabPage.Name = "aboutTabPage";
            this.aboutTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aboutTabPage.Size = new System.Drawing.Size(1092, 564);
            this.aboutTabPage.TabIndex = 3;
            this.aboutTabPage.Text = "关于";
            this.aboutTabPage.UseVisualStyleBackColor = true;
            // 
            // wechatPictureBox
            // 
            this.wechatPictureBox.BackgroundImage = global::WSAInstallTool.Properties.Resources.wechat_small;
            this.wechatPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.wechatPictureBox.InitialImage = global::WSAInstallTool.Properties.Resources.wechat_small;
            this.wechatPictureBox.Location = new System.Drawing.Point(807, 306);
            this.wechatPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wechatPictureBox.Name = "wechatPictureBox";
            this.wechatPictureBox.Size = new System.Drawing.Size(228, 216);
            this.wechatPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.wechatPictureBox.TabIndex = 7;
            this.wechatPictureBox.TabStop = false;
            // 
            // alipayPicctureBox
            // 
            this.alipayPicctureBox.BackgroundImage = global::WSAInstallTool.Properties.Resources.alipay_small;
            this.alipayPicctureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.alipayPicctureBox.Location = new System.Drawing.Point(807, 58);
            this.alipayPicctureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.alipayPicctureBox.Name = "alipayPicctureBox";
            this.alipayPicctureBox.Size = new System.Drawing.Size(228, 216);
            this.alipayPicctureBox.TabIndex = 6;
            this.alipayPicctureBox.TabStop = false;
            // 
            // giteeLinkLabel
            // 
            this.giteeLinkLabel.AutoSize = true;
            this.giteeLinkLabel.Location = new System.Drawing.Point(148, 232);
            this.giteeLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.giteeLinkLabel.Name = "giteeLinkLabel";
            this.giteeLinkLabel.Size = new System.Drawing.Size(130, 24);
            this.giteeLinkLabel.TabIndex = 5;
            this.giteeLinkLabel.TabStop = true;
            this.giteeLinkLabel.Text = "linkLabel1";
            this.giteeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.giteeLinkLabel_LinkClicked);
            // 
            // giteeLabel
            // 
            this.giteeLabel.AutoSize = true;
            this.giteeLabel.Location = new System.Drawing.Point(44, 232);
            this.giteeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.giteeLabel.Name = "giteeLabel";
            this.giteeLabel.Size = new System.Drawing.Size(94, 24);
            this.giteeLabel.TabIndex = 4;
            this.giteeLabel.Text = "Gitee：";
            // 
            // githubLinkLabel
            // 
            this.githubLinkLabel.AutoSize = true;
            this.githubLinkLabel.Location = new System.Drawing.Point(148, 186);
            this.githubLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.githubLinkLabel.Name = "githubLinkLabel";
            this.githubLinkLabel.Size = new System.Drawing.Size(190, 24);
            this.githubLinkLabel.TabIndex = 3;
            this.githubLinkLabel.TabStop = true;
            this.githubLinkLabel.Text = "githubLinkLabel";
            this.githubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubLinkLabel_LinkClicked);
            // 
            // githubLabel
            // 
            this.githubLabel.AutoSize = true;
            this.githubLabel.Location = new System.Drawing.Point(44, 186);
            this.githubLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.githubLabel.Name = "githubLabel";
            this.githubLabel.Size = new System.Drawing.Size(82, 24);
            this.githubLabel.TabIndex = 2;
            this.githubLabel.Text = "Github";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(44, 132);
            this.authorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(58, 24);
            this.authorLabel.TabIndex = 1;
            this.authorLabel.Text = "作者";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(44, 76);
            this.versionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(106, 24);
            this.versionLabel.TabIndex = 0;
            this.versionLabel.Text = "版本号：";
            // 
            // tipLabel
            // 
            this.tipLabel.AutoSize = true;
            this.tipLabel.Location = new System.Drawing.Point(30, 641);
            this.tipLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.Size = new System.Drawing.Size(502, 24);
            this.tipLabel.TabIndex = 1;
            this.tipLabel.Text = "注:该页面下所有的偏好设置都是全局生效的。";
            // 
            // alipayLabel
            // 
            this.alipayLabel.AutoSize = true;
            this.alipayLabel.Location = new System.Drawing.Point(883, 278);
            this.alipayLabel.Name = "alipayLabel";
            this.alipayLabel.Size = new System.Drawing.Size(82, 24);
            this.alipayLabel.TabIndex = 8;
            this.alipayLabel.Text = "支付宝";
            // 
            // wechatLabel
            // 
            this.wechatLabel.AutoSize = true;
            this.wechatLabel.Location = new System.Drawing.Point(898, 526);
            this.wechatLabel.Name = "wechatLabel";
            this.wechatLabel.Size = new System.Drawing.Size(58, 24);
            this.wechatLabel.TabIndex = 9;
            this.wechatLabel.Text = "微信";
            // 
            // donateLabel
            // 
            this.donateLabel.AutoSize = true;
            this.donateLabel.Location = new System.Drawing.Point(855, 18);
            this.donateLabel.Name = "donateLabel";
            this.donateLabel.Size = new System.Drawing.Size(130, 24);
            this.donateLabel.TabIndex = 10;
            this.donateLabel.Text = "请我吃辣条";
            // 
            // thankLabel
            // 
            this.thankLabel.AutoSize = true;
            this.thankLabel.Location = new System.Drawing.Point(48, 293);
            this.thankLabel.Name = "thankLabel";
            this.thankLabel.Size = new System.Drawing.Size(58, 24);
            this.thankLabel.TabIndex = 11;
            this.thankLabel.Text = "感谢";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 674);
            this.Controls.Add(this.tipLabel);
            this.Controls.Add(this.settingTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.connectGroupBox.ResumeLayout(false);
            this.connectGroupBox.PerformLayout();
            this.installMethodGroupBox.ResumeLayout(false);
            this.installMethodGroupBox.PerformLayout();
            this.languageTabPage.ResumeLayout(false);
            this.languageTabPage.PerformLayout();
            this.experimentalFunctionTabPage.ResumeLayout(false);
            this.experimentalFunctionTabPage.PerformLayout();
            this.aboutTabPage.ResumeLayout(false);
            this.aboutTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wechatPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alipayPicctureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl settingTabControl;
        private System.Windows.Forms.TabPage adbTabPage;
        private System.Windows.Forms.RadioButton degradedOverlayRadioButton;
        private System.Windows.Forms.RadioButton overlayRadioButton;
        private System.Windows.Forms.Label installMethodLabel;
        private System.Windows.Forms.CheckBox afterInstalledCloseCheckBox;
        private System.Windows.Forms.Label tipLabel;
        private System.Windows.Forms.TabPage languageTabPage;
        private System.Windows.Forms.Label selectLanguageLabel;
        private System.Windows.Forms.ComboBox selectLanguageComboBox;
        private System.Windows.Forms.Label selectLanguageTipLabel;
        private System.Windows.Forms.TabPage experimentalFunctionTabPage;
        private System.Windows.Forms.CheckBox badApkCheckBox;
        private System.Windows.Forms.Label maliciousApkTipLabel;

        private System.Windows.Forms.GroupBox installMethodGroupBox;
        private System.Windows.Forms.TextBox connectTextBox;
        private System.Windows.Forms.GroupBox connectGroupBox;
        private System.Windows.Forms.CheckBox connectCheckBox;
        private System.Windows.Forms.CheckBox professionalCheckBox;
        private System.Windows.Forms.TabPage aboutTabPage;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label githubLabel;
        private System.Windows.Forms.LinkLabel githubLinkLabel;
        private System.Windows.Forms.Label giteeLabel;
        private System.Windows.Forms.LinkLabel giteeLinkLabel;
        private System.Windows.Forms.PictureBox wechatPictureBox;
        private System.Windows.Forms.PictureBox alipayPicctureBox;
        private System.Windows.Forms.Label wechatLabel;
        private System.Windows.Forms.Label alipayLabel;
        private System.Windows.Forms.Label donateLabel;
        private System.Windows.Forms.Label thankLabel;
    }
}