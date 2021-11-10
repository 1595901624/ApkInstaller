namespace WSAInstallTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.installButton = new System.Windows.Forms.Button();
            this.uninstallButton = new System.Windows.Forms.Button();
            this.aboutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.installApkIconButton = new System.Windows.Forms.Button();
            this.uninsallApkIconButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // installButton
            // 
            this.installButton.Location = new System.Drawing.Point(61, 24);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(191, 58);
            this.installButton.TabIndex = 0;
            this.installButton.Text = "一键关联APK";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // uninstallButton
            // 
            this.uninstallButton.Location = new System.Drawing.Point(61, 104);
            this.uninstallButton.Name = "uninstallButton";
            this.uninstallButton.Size = new System.Drawing.Size(191, 56);
            this.uninstallButton.TabIndex = 1;
            this.uninstallButton.Text = "一键清除关联";
            this.uninstallButton.UseVisualStyleBackColor = true;
            this.uninstallButton.Click += new System.EventHandler(this.uninstallButton_Click);
            // 
            // aboutLinkLabel
            // 
            this.aboutLinkLabel.AutoSize = true;
            this.aboutLinkLabel.Location = new System.Drawing.Point(22, 225);
            this.aboutLinkLabel.Name = "aboutLinkLabel";
            this.aboutLinkLabel.Size = new System.Drawing.Size(37, 15);
            this.aboutLinkLabel.TabIndex = 2;
            this.aboutLinkLabel.TabStop = true;
            this.aboutLinkLabel.Text = "关于";
            this.aboutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aboutLinkLabel_LinkClicked);
            // 
            // installApkIconButton
            // 
            this.installApkIconButton.Location = new System.Drawing.Point(87, 24);
            this.installApkIconButton.Name = "installApkIconButton";
            this.installApkIconButton.Size = new System.Drawing.Size(173, 58);
            this.installApkIconButton.TabIndex = 3;
            this.installApkIconButton.Text = "显示APK自身图标";
            this.installApkIconButton.UseVisualStyleBackColor = true;
            this.installApkIconButton.Click += new System.EventHandler(this.installApkIconButton_Click);
            // 
            // uninsallApkIconButton
            // 
            this.uninsallApkIconButton.Location = new System.Drawing.Point(87, 101);
            this.uninsallApkIconButton.Name = "uninsallApkIconButton";
            this.uninsallApkIconButton.Size = new System.Drawing.Size(173, 56);
            this.uninsallApkIconButton.TabIndex = 4;
            this.uninsallApkIconButton.Text = "清除APK自身图标";
            this.uninsallApkIconButton.UseVisualStyleBackColor = true;
            this.uninsallApkIconButton.Click += new System.EventHandler(this.uninsallApkIconButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.installButton);
            this.groupBox1.Controls.Add(this.uninstallButton);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 187);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "关联APK";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.uninsallApkIconButton);
            this.groupBox2.Controls.Add(this.installApkIconButton);
            this.groupBox2.Location = new System.Drawing.Point(399, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 184);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "APK图标";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 255);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.aboutLinkLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APK安装器";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.Button uninstallButton;
        private System.Windows.Forms.LinkLabel aboutLinkLabel;
        private System.Windows.Forms.Button installApkIconButton;
        private System.Windows.Forms.Button uninsallApkIconButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}