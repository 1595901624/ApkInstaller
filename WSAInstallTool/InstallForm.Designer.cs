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
            this.iconPictureBox.Location = new System.Drawing.Point(529, 16);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(139, 134);
            this.iconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox.TabIndex = 2;
            this.iconPictureBox.TabStop = false;
            // 
            // permissionLabel
            // 
            this.permissionLabel.AutoSize = true;
            this.permissionLabel.Location = new System.Drawing.Point(23, 165);
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
            this.installButton.Location = new System.Drawing.Point(529, 261);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(132, 45);
            this.installButton.TabIndex = 4;
            this.installButton.Text = "安装";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // installProgressBar
            // 
            this.installProgressBar.Location = new System.Drawing.Point(26, 324);
            this.installProgressBar.Name = "installProgressBar";
            this.installProgressBar.Size = new System.Drawing.Size(635, 23);
            this.installProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.installProgressBar.TabIndex = 5;
            this.installProgressBar.Visible = false;
            // 
            // InstallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 359);
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
    }
}

