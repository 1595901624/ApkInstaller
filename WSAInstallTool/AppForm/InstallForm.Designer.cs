namespace WSAInstallTool
{
    partial class InstallForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallForm));
            this.packageNameLabel = new System.Windows.Forms.Label();
            this.versionNameLabel = new System.Windows.Forms.Label();
            this.permissionLabel = new System.Windows.Forms.Label();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.installButton = new System.Windows.Forms.Button();
            this.installProgressBar = new System.Windows.Forms.ProgressBar();
            this.moreLinkLabel = new System.Windows.Forms.LinkLabel();
            this.minVersionLabel = new System.Windows.Forms.Label();
            this.spaceLabel = new System.Windows.Forms.Label();
            this.badApkPictureBox = new System.Windows.Forms.PictureBox();
            this.settingButton = new System.Windows.Forms.Button();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.realPackageNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.badApkPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // packageNameLabel
            // 
            this.packageNameLabel.AutoSize = true;
            this.packageNameLabel.Location = new System.Drawing.Point(17, 77);
            this.packageNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.packageNameLabel.Name = "packageNameLabel";
            this.packageNameLabel.Size = new System.Drawing.Size(77, 12);
            this.packageNameLabel.TabIndex = 0;
            this.packageNameLabel.Text = "packageName:";
            // 
            // versionNameLabel
            // 
            this.versionNameLabel.AutoSize = true;
            this.versionNameLabel.Location = new System.Drawing.Point(17, 98);
            this.versionNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.versionNameLabel.Name = "versionNameLabel";
            this.versionNameLabel.Size = new System.Drawing.Size(71, 12);
            this.versionNameLabel.TabIndex = 1;
            this.versionNameLabel.Text = "versionName";
            // 
            // permissionLabel
            // 
            this.permissionLabel.AutoSize = true;
            this.permissionLabel.Location = new System.Drawing.Point(18, 164);
            this.permissionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.permissionLabel.Name = "permissionLabel";
            this.permissionLabel.Size = new System.Drawing.Size(65, 12);
            this.permissionLabel.TabIndex = 1;
            this.permissionLabel.Text = "permission";
            // 
            // appNameLabel
            // 
            this.appNameLabel.AutoEllipsis = true;
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("宋体", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.appNameLabel.Location = new System.Drawing.Point(20, 22);
            this.appNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.appNameLabel.MaximumSize = new System.Drawing.Size(420, 35);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(91, 35);
            this.appNameLabel.TabIndex = 3;
            this.appNameLabel.Text = "Name";
            // 
            // installButton
            // 
            this.installButton.Location = new System.Drawing.Point(442, 309);
            this.installButton.Margin = new System.Windows.Forms.Padding(2);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(99, 36);
            this.installButton.TabIndex = 4;
            this.installButton.Text = "安装";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // installProgressBar
            // 
            this.installProgressBar.Location = new System.Drawing.Point(54, 319);
            this.installProgressBar.Margin = new System.Windows.Forms.Padding(2);
            this.installProgressBar.Name = "installProgressBar";
            this.installProgressBar.Size = new System.Drawing.Size(380, 26);
            this.installProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.installProgressBar.TabIndex = 5;
            this.installProgressBar.Visible = false;
            // 
            // moreLinkLabel
            // 
            this.moreLinkLabel.AutoSize = true;
            this.moreLinkLabel.Location = new System.Drawing.Point(203, 300);
            this.moreLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.moreLinkLabel.Name = "moreLinkLabel";
            this.moreLinkLabel.Size = new System.Drawing.Size(77, 12);
            this.moreLinkLabel.TabIndex = 6;
            this.moreLinkLabel.TabStop = true;
            this.moreLinkLabel.Text = "查看更多权限";
            this.moreLinkLabel.Visible = false;
            this.moreLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.moreLinkLabel_LinkClicked);
            // 
            // minVersionLabel
            // 
            this.minVersionLabel.AutoSize = true;
            this.minVersionLabel.Location = new System.Drawing.Point(17, 119);
            this.minVersionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minVersionLabel.Name = "minVersionLabel";
            this.minVersionLabel.Size = new System.Drawing.Size(65, 12);
            this.minVersionLabel.TabIndex = 7;
            this.minVersionLabel.Text = "minVersion";
            // 
            // spaceLabel
            // 
            this.spaceLabel.AutoSize = true;
            this.spaceLabel.Location = new System.Drawing.Point(17, 142);
            this.spaceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.spaceLabel.Name = "spaceLabel";
            this.spaceLabel.Size = new System.Drawing.Size(41, 12);
            this.spaceLabel.TabIndex = 8;
            this.spaceLabel.Text = "space:";
            // 
            // badApkPictureBox
            // 
            this.badApkPictureBox.Image = global::WSAInstallTool.Properties.Resources.bad_apk_safety;
            this.badApkPictureBox.InitialImage = null;
            this.badApkPictureBox.Location = new System.Drawing.Point(436, 126);
            this.badApkPictureBox.Name = "badApkPictureBox";
            this.badApkPictureBox.Size = new System.Drawing.Size(100, 50);
            this.badApkPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.badApkPictureBox.TabIndex = 10;
            this.badApkPictureBox.TabStop = false;
            this.badApkPictureBox.Visible = false;
            // 
            // settingButton
            // 
            this.settingButton.BackgroundImage = global::WSAInstallTool.Properties.Resources.setting;
            this.settingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingButton.Location = new System.Drawing.Point(20, 319);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(29, 26);
            this.settingButton.TabIndex = 9;
            this.settingButton.UseVisualStyleBackColor = true;
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.Location = new System.Drawing.Point(436, 14);
            this.iconPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(104, 107);
            this.iconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox.TabIndex = 2;
            this.iconPictureBox.TabStop = false;
            // 
            // realPackageNameLabel
            // 
            this.realPackageNameLabel.AutoSize = true;
            this.realPackageNameLabel.Location = new System.Drawing.Point(98, 77);
            this.realPackageNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.realPackageNameLabel.Name = "realPackageNameLabel";
            this.realPackageNameLabel.Size = new System.Drawing.Size(0, 12);
            this.realPackageNameLabel.TabIndex = 11;
            // 
            // InstallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(552, 356);
            this.Controls.Add(this.realPackageNameLabel);
            this.Controls.Add(this.badApkPictureBox);
            this.Controls.Add(this.settingButton);
            this.Controls.Add(this.spaceLabel);
            this.Controls.Add(this.minVersionLabel);
            this.Controls.Add(this.moreLinkLabel);
            this.Controls.Add(this.installProgressBar);
            this.Controls.Add(this.installButton);
            this.Controls.Add(this.appNameLabel);
            this.Controls.Add(this.iconPictureBox);
            this.Controls.Add(this.permissionLabel);
            this.Controls.Add(this.versionNameLabel);
            this.Controls.Add(this.packageNameLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InstallForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APK安装";
            this.Load += new System.EventHandler(this.InstallForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.badApkPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label packageNameLabel;
        private System.Windows.Forms.Label versionNameLabel;
        private System.Windows.Forms.PictureBox iconPictureBox;
        private System.Windows.Forms.Label permissionLabel;
        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.ProgressBar installProgressBar;
        private System.Windows.Forms.LinkLabel moreLinkLabel;
        private System.Windows.Forms.Label minVersionLabel;
        private System.Windows.Forms.Label spaceLabel;
        private System.Windows.Forms.Button settingButton;
        private System.Windows.Forms.PictureBox badApkPictureBox;
        private System.Windows.Forms.Label realPackageNameLabel;
    }
}

