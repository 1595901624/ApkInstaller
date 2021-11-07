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
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.permissionLabel = new System.Windows.Forms.Label();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.installButton = new System.Windows.Forms.Button();
            this.installProgressBar = new System.Windows.Forms.ProgressBar();
            this.moreLinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // packageNameLabel
            // 
            this.packageNameLabel.AutoSize = true;
            this.packageNameLabel.Location = new System.Drawing.Point(23, 107);
            this.packageNameLabel.Name = "packageNameLabel";
            this.packageNameLabel.Size = new System.Drawing.Size(103, 15);
            this.packageNameLabel.TabIndex = 0;
            this.packageNameLabel.Text = "packageName:";
            // 
            // versionNameLabel
            // 
            this.versionNameLabel.AutoSize = true;
            this.versionNameLabel.Location = new System.Drawing.Point(23, 136);
            this.versionNameLabel.Name = "versionNameLabel";
            this.versionNameLabel.Size = new System.Drawing.Size(95, 15);
            this.versionNameLabel.TabIndex = 1;
            this.versionNameLabel.Text = "versionName";
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.Location = new System.Drawing.Point(582, 17);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(139, 134);
            this.iconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox.TabIndex = 2;
            this.iconPictureBox.TabStop = false;
            // 
            // permissionLabel
            // 
            this.permissionLabel.AutoSize = true;
            this.permissionLabel.Location = new System.Drawing.Point(23, 180);
            this.permissionLabel.Name = "permissionLabel";
            this.permissionLabel.Size = new System.Drawing.Size(87, 15);
            this.permissionLabel.TabIndex = 1;
            this.permissionLabel.Text = "permission";
            // 
            // appNameLabel
            // 
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("宋体", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.appNameLabel.Location = new System.Drawing.Point(26, 28);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(111, 43);
            this.appNameLabel.TabIndex = 3;
            this.appNameLabel.Text = "Name";
            // 
            // installButton
            // 
            this.installButton.Location = new System.Drawing.Point(589, 345);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(132, 45);
            this.installButton.TabIndex = 4;
            this.installButton.Text = "安装";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // installProgressBar
            // 
            this.installProgressBar.Location = new System.Drawing.Point(26, 406);
            this.installProgressBar.Name = "installProgressBar";
            this.installProgressBar.Size = new System.Drawing.Size(695, 23);
            this.installProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.installProgressBar.TabIndex = 5;
            this.installProgressBar.Visible = false;
            // 
            // moreLinkLabel
            // 
            this.moreLinkLabel.AutoSize = true;
            this.moreLinkLabel.Location = new System.Drawing.Point(262, 345);
            this.moreLinkLabel.Name = "moreLinkLabel";
            this.moreLinkLabel.Size = new System.Drawing.Size(67, 15);
            this.moreLinkLabel.TabIndex = 6;
            this.moreLinkLabel.TabStop = true;
            this.moreLinkLabel.Text = "查看更多";
            this.moreLinkLabel.Visible = false;
            this.moreLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.moreLinkLabel_LinkClicked);
            // 
            // InstallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 441);
            this.Controls.Add(this.moreLinkLabel);
            this.Controls.Add(this.installProgressBar);
            this.Controls.Add(this.installButton);
            this.Controls.Add(this.appNameLabel);
            this.Controls.Add(this.iconPictureBox);
            this.Controls.Add(this.permissionLabel);
            this.Controls.Add(this.versionNameLabel);
            this.Controls.Add(this.packageNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InstallForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APK安装";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

