namespace WSAInstallTool
{
    partial class InstallFormPro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallFormPro));
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
            this.packageNameLabel.Location = new System.Drawing.Point(35, 155);
            this.packageNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.packageNameLabel.Name = "packageNameLabel";
            this.packageNameLabel.Size = new System.Drawing.Size(154, 24);
            this.packageNameLabel.TabIndex = 0;
            this.packageNameLabel.Text = "packageName:";
            // 
            // versionNameLabel
            // 
            this.versionNameLabel.AutoSize = true;
            this.versionNameLabel.Location = new System.Drawing.Point(35, 196);
            this.versionNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.versionNameLabel.Name = "versionNameLabel";
            this.versionNameLabel.Size = new System.Drawing.Size(142, 24);
            this.versionNameLabel.TabIndex = 1;
            this.versionNameLabel.Text = "versionName";
            // 
            // permissionLabel
            // 
            this.permissionLabel.AutoSize = true;
            this.permissionLabel.Location = new System.Drawing.Point(36, 328);
            this.permissionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.permissionLabel.Name = "permissionLabel";
            this.permissionLabel.Size = new System.Drawing.Size(130, 24);
            this.permissionLabel.TabIndex = 1;
            this.permissionLabel.Text = "permission";
            // 
            // appNameLabel
            // 
            this.appNameLabel.AutoEllipsis = true;
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("宋体", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.appNameLabel.Location = new System.Drawing.Point(40, 44);
            this.appNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.appNameLabel.MaximumSize = new System.Drawing.Size(840, 69);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(174, 69);
            this.appNameLabel.TabIndex = 3;
            this.appNameLabel.Text = "Name";
            // 
            // installButton
            // 
            this.installButton.Location = new System.Drawing.Point(884, 619);
            this.installButton.Margin = new System.Windows.Forms.Padding(4);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(197, 72);
            this.installButton.TabIndex = 4;
            this.installButton.Text = "安装";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // installProgressBar
            // 
            this.installProgressBar.Location = new System.Drawing.Point(108, 637);
            this.installProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.installProgressBar.Name = "installProgressBar";
            this.installProgressBar.Size = new System.Drawing.Size(760, 52);
            this.installProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.installProgressBar.TabIndex = 5;
            this.installProgressBar.Visible = false;
            // 
            // moreLinkLabel
            // 
            this.moreLinkLabel.AutoSize = true;
            this.moreLinkLabel.Location = new System.Drawing.Point(405, 600);
            this.moreLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.moreLinkLabel.Name = "moreLinkLabel";
            this.moreLinkLabel.Size = new System.Drawing.Size(154, 24);
            this.moreLinkLabel.TabIndex = 6;
            this.moreLinkLabel.TabStop = true;
            this.moreLinkLabel.Text = "查看更多权限";
            this.moreLinkLabel.Visible = false;
            this.moreLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.moreLinkLabel_LinkClicked);
            // 
            // minVersionLabel
            // 
            this.minVersionLabel.AutoSize = true;
            this.minVersionLabel.Location = new System.Drawing.Point(35, 237);
            this.minVersionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minVersionLabel.Name = "minVersionLabel";
            this.minVersionLabel.Size = new System.Drawing.Size(130, 24);
            this.minVersionLabel.TabIndex = 7;
            this.minVersionLabel.Text = "minVersion";
            // 
            // spaceLabel
            // 
            this.spaceLabel.AutoSize = true;
            this.spaceLabel.Location = new System.Drawing.Point(35, 284);
            this.spaceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.spaceLabel.Name = "spaceLabel";
            this.spaceLabel.Size = new System.Drawing.Size(82, 24);
            this.spaceLabel.TabIndex = 8;
            this.spaceLabel.Text = "space:";
            // 
            // badApkPictureBox
            // 
            this.badApkPictureBox.Image = global::WSAInstallTool.Properties.Resources.bad_apk_safety;
            this.badApkPictureBox.InitialImage = null;
            this.badApkPictureBox.Location = new System.Drawing.Point(872, 252);
            this.badApkPictureBox.Margin = new System.Windows.Forms.Padding(5);
            this.badApkPictureBox.Name = "badApkPictureBox";
            this.badApkPictureBox.Size = new System.Drawing.Size(200, 100);
            this.badApkPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.badApkPictureBox.TabIndex = 10;
            this.badApkPictureBox.TabStop = false;
            this.badApkPictureBox.Visible = false;
            // 
            // settingButton
            // 
            this.settingButton.BackgroundImage = global::WSAInstallTool.Properties.Resources.setting;
            this.settingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingButton.Location = new System.Drawing.Point(40, 637);
            this.settingButton.Margin = new System.Windows.Forms.Padding(5);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(59, 52);
            this.settingButton.TabIndex = 9;
            this.settingButton.UseVisualStyleBackColor = true;
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.Location = new System.Drawing.Point(872, 28);
            this.iconPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(208, 213);
            this.iconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox.TabIndex = 2;
            this.iconPictureBox.TabStop = false;
            // 
            // realPackageNameLabel
            // 
            this.realPackageNameLabel.AutoSize = true;
            this.realPackageNameLabel.Location = new System.Drawing.Point(196, 155);
            this.realPackageNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.realPackageNameLabel.Name = "realPackageNameLabel";
            this.realPackageNameLabel.Size = new System.Drawing.Size(0, 24);
            this.realPackageNameLabel.TabIndex = 11;
            // 
            // InstallFormPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1104, 706);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InstallFormPro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APK安装";
            this.Load += new System.EventHandler(this.InstallFormPro_Load);
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

