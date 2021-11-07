namespace WSAInstallTool
{
    partial class DeviceSelectForm
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
            this.deviceSelectTipLabel = new System.Windows.Forms.Label();
            this.deviceComboBox = new System.Windows.Forms.ComboBox();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deviceSelectTipLabel
            // 
            this.deviceSelectTipLabel.AutoSize = true;
            this.deviceSelectTipLabel.Location = new System.Drawing.Point(35, 31);
            this.deviceSelectTipLabel.Name = "deviceSelectTipLabel";
            this.deviceSelectTipLabel.Size = new System.Drawing.Size(292, 15);
            this.deviceSelectTipLabel.TabIndex = 0;
            this.deviceSelectTipLabel.Text = "发现多款安卓设备，请选择要安装的设备：";
            // 
            // deviceComboBox
            // 
            this.deviceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviceComboBox.FormattingEnabled = true;
            this.deviceComboBox.Location = new System.Drawing.Point(68, 81);
            this.deviceComboBox.Name = "deviceComboBox";
            this.deviceComboBox.Size = new System.Drawing.Size(259, 23);
            this.deviceComboBox.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(115, 135);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(165, 47);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "确定安装";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // DeviceSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 194);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.deviceComboBox);
            this.Controls.Add(this.deviceSelectTipLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DeviceSelectForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择安装的设备";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeviceSelectForm_FormClosing);
            this.Load += new System.EventHandler(this.DeviceSelectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deviceSelectTipLabel;
        private System.Windows.Forms.ComboBox deviceComboBox;
        private System.Windows.Forms.Button okButton;
    }
}