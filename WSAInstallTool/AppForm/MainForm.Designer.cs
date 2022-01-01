namespace WSAInstallTool
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.installButton = new System.Windows.Forms.Button();
            this.uninstallButton = new System.Windows.Forms.Button();
            this.aboutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.installApkIconButton = new System.Windows.Forms.Button();
            this.uninsallApkIconButton = new System.Windows.Forms.Button();
            this.associateApkGroup = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.readMeLabel = new System.Windows.Forms.LinkLabel();
            this.settingLinkLabel = new System.Windows.Forms.LinkLabel();
            this.associateApkGroup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // installButton
            // 
            this.installButton.Location = new System.Drawing.Point(46, 19);
            this.installButton.Margin = new System.Windows.Forms.Padding(2);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(158, 46);
            this.installButton.TabIndex = 0;
            this.installButton.Text = "一键安装";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // uninstallButton
            // 
            this.uninstallButton.Location = new System.Drawing.Point(46, 83);
            this.uninstallButton.Margin = new System.Windows.Forms.Padding(2);
            this.uninstallButton.Name = "uninstallButton";
            this.uninstallButton.Size = new System.Drawing.Size(158, 45);
            this.uninstallButton.TabIndex = 1;
            this.uninstallButton.Text = "卸载软件/清除旧版本";
            this.uninstallButton.UseVisualStyleBackColor = true;
            this.uninstallButton.Click += new System.EventHandler(this.uninstallButton_Click);
            // 
            // aboutLinkLabel
            // 
            this.aboutLinkLabel.AutoSize = true;
            this.aboutLinkLabel.Location = new System.Drawing.Point(16, 180);
            this.aboutLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aboutLinkLabel.Name = "aboutLinkLabel";
            this.aboutLinkLabel.Size = new System.Drawing.Size(29, 12);
            this.aboutLinkLabel.TabIndex = 2;
            this.aboutLinkLabel.TabStop = true;
            this.aboutLinkLabel.Text = "关于";
            this.aboutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aboutLinkLabel_LinkClicked);
            // 
            // installApkIconButton
            // 
            this.installApkIconButton.Location = new System.Drawing.Point(65, 19);
            this.installApkIconButton.Margin = new System.Windows.Forms.Padding(2);
            this.installApkIconButton.Name = "installApkIconButton";
            this.installApkIconButton.Size = new System.Drawing.Size(130, 46);
            this.installApkIconButton.TabIndex = 3;
            this.installApkIconButton.Text = "显示APK自身图标";
            this.installApkIconButton.UseVisualStyleBackColor = true;
            this.installApkIconButton.Click += new System.EventHandler(this.installApkIconButton_Click);
            // 
            // uninsallApkIconButton
            // 
            this.uninsallApkIconButton.Location = new System.Drawing.Point(65, 81);
            this.uninsallApkIconButton.Margin = new System.Windows.Forms.Padding(2);
            this.uninsallApkIconButton.Name = "uninsallApkIconButton";
            this.uninsallApkIconButton.Size = new System.Drawing.Size(130, 45);
            this.uninsallApkIconButton.TabIndex = 4;
            this.uninsallApkIconButton.Text = "清除APK自身图标";
            this.uninsallApkIconButton.UseVisualStyleBackColor = true;
            this.uninsallApkIconButton.Click += new System.EventHandler(this.uninsallApkIconButton_Click);
            // 
            // associateApkGroup
            // 
            this.associateApkGroup.Controls.Add(this.installButton);
            this.associateApkGroup.Controls.Add(this.uninstallButton);
            this.associateApkGroup.Location = new System.Drawing.Point(19, 10);
            this.associateApkGroup.Margin = new System.Windows.Forms.Padding(2);
            this.associateApkGroup.Name = "associateApkGroup";
            this.associateApkGroup.Padding = new System.Windows.Forms.Padding(2);
            this.associateApkGroup.Size = new System.Drawing.Size(248, 150);
            this.associateApkGroup.TabIndex = 5;
            this.associateApkGroup.TabStop = false;
            this.associateApkGroup.Text = "关联APK";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.uninsallApkIconButton);
            this.groupBox2.Controls.Add(this.installApkIconButton);
            this.groupBox2.Location = new System.Drawing.Point(299, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(244, 147);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2、APK图标";
            // 
            // readMeLabel
            // 
            this.readMeLabel.AutoSize = true;
            this.readMeLabel.Location = new System.Drawing.Point(50, 180);
            this.readMeLabel.Name = "readMeLabel";
            this.readMeLabel.Size = new System.Drawing.Size(65, 12);
            this.readMeLabel.TabIndex = 7;
            this.readMeLabel.TabStop = true;
            this.readMeLabel.Text = "使用前必读";
            this.readMeLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.readMeLabel_LinkClicked);
            // 
            // settingLinkLabel
            // 
            this.settingLinkLabel.AutoSize = true;
            this.settingLinkLabel.Location = new System.Drawing.Point(121, 180);
            this.settingLinkLabel.Name = "settingLinkLabel";
            this.settingLinkLabel.Size = new System.Drawing.Size(53, 12);
            this.settingLinkLabel.TabIndex = 8;
            this.settingLinkLabel.TabStop = true;
            this.settingLinkLabel.Text = "偏好设置";
            this.settingLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.settingLinkLabel_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 204);
            this.Controls.Add(this.settingLinkLabel);
            this.Controls.Add(this.readMeLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.associateApkGroup);
            this.Controls.Add(this.aboutLinkLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apk Installer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.associateApkGroup.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox associateApkGroup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel readMeLabel;
        private System.Windows.Forms.LinkLabel settingLinkLabel;
    }
}