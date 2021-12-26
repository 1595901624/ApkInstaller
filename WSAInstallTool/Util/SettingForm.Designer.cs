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
            this.tipLabel = new System.Windows.Forms.Label();
            this.settingTabControl.SuspendLayout();
            this.adbTabPage.SuspendLayout();
            this.installMethodPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingTabControl
            // 
            this.settingTabControl.Controls.Add(this.adbTabPage);
            this.settingTabControl.Location = new System.Drawing.Point(13, 12);
            this.settingTabControl.Name = "settingTabControl";
            this.settingTabControl.SelectedIndex = 0;
            this.settingTabControl.Size = new System.Drawing.Size(554, 297);
            this.settingTabControl.TabIndex = 0;
            // 
            // adbTabPage
            // 
            this.adbTabPage.Controls.Add(this.afterInstalledCloseCheckBox);
            this.adbTabPage.Controls.Add(this.installMethodPanel);
            this.adbTabPage.Location = new System.Drawing.Point(4, 22);
            this.adbTabPage.Name = "adbTabPage";
            this.adbTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.adbTabPage.Size = new System.Drawing.Size(546, 271);
            this.adbTabPage.TabIndex = 0;
            this.adbTabPage.Text = "安装设置";
            this.adbTabPage.UseVisualStyleBackColor = true;
            // 
            // afterInstalledCloseCheckBox
            // 
            this.afterInstalledCloseCheckBox.AutoSize = true;
            this.afterInstalledCloseCheckBox.Location = new System.Drawing.Point(14, 16);
            this.afterInstalledCloseCheckBox.Name = "afterInstalledCloseCheckBox";
            this.afterInstalledCloseCheckBox.Size = new System.Drawing.Size(156, 16);
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
            this.installMethodPanel.Location = new System.Drawing.Point(9, 48);
            this.installMethodPanel.Name = "installMethodPanel";
            this.installMethodPanel.Size = new System.Drawing.Size(534, 48);
            this.installMethodPanel.TabIndex = 3;
            // 
            // installMethodLabel
            // 
            this.installMethodLabel.AutoSize = true;
            this.installMethodLabel.Location = new System.Drawing.Point(3, 18);
            this.installMethodLabel.Name = "installMethodLabel";
            this.installMethodLabel.Size = new System.Drawing.Size(65, 12);
            this.installMethodLabel.TabIndex = 2;
            this.installMethodLabel.Text = "安装方式：";
            // 
            // degradedOverlayRadioButton
            // 
            this.degradedOverlayRadioButton.AutoSize = true;
            this.degradedOverlayRadioButton.Location = new System.Drawing.Point(193, 18);
            this.degradedOverlayRadioButton.Name = "degradedOverlayRadioButton";
            this.degradedOverlayRadioButton.Size = new System.Drawing.Size(95, 16);
            this.degradedOverlayRadioButton.TabIndex = 1;
            this.degradedOverlayRadioButton.TabStop = true;
            this.degradedOverlayRadioButton.Text = "降级覆盖安装";
            this.degradedOverlayRadioButton.UseVisualStyleBackColor = true;
            this.degradedOverlayRadioButton.CheckedChanged += new System.EventHandler(this.degradedOverlayRadioButton_CheckedChanged);
            // 
            // overlayRadioButton
            // 
            this.overlayRadioButton.AutoSize = true;
            this.overlayRadioButton.Location = new System.Drawing.Point(82, 18);
            this.overlayRadioButton.Name = "overlayRadioButton";
            this.overlayRadioButton.Size = new System.Drawing.Size(71, 16);
            this.overlayRadioButton.TabIndex = 0;
            this.overlayRadioButton.TabStop = true;
            this.overlayRadioButton.Text = "覆盖安装";
            this.overlayRadioButton.UseVisualStyleBackColor = true;
            this.overlayRadioButton.CheckedChanged += new System.EventHandler(this.overlayRadioButton_CheckedChanged);
            // 
            // tipLabel
            // 
            this.tipLabel.AutoSize = true;
            this.tipLabel.Location = new System.Drawing.Point(15, 312);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.Size = new System.Drawing.Size(251, 12);
            this.tipLabel.TabIndex = 1;
            this.tipLabel.Text = "注:该页面下所有的偏好设置都是全局生效的。";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 337);
            this.Controls.Add(this.tipLabel);
            this.Controls.Add(this.settingTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
    }
}