using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSAInstallTool
{
    public partial class DeviceSelectForm : Form
    {
        // 设备列表
        private List<string> mDevcies = new List<string>();

        public string resultDevice = "";

        public DeviceSelectForm(List<string> deviceList)
        {
            InitializeComponent();
            this.mDevcies = deviceList;
        }

        private void DeviceSelectForm_Load(object sender, EventArgs e)
        {
            foreach (string str in mDevcies)
            {
                deviceComboBox.Items.Add(str);
            }

            if (mDevcies.Count > 0)
            {
                deviceComboBox.SelectedIndex = 0;
            }
            
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Debug.Write("deviceComboBox.SelectedText => " + mDevcies[deviceComboBox.SelectedIndex]);
            this.resultDevice = mDevcies[deviceComboBox.SelectedIndex];
        }

        private void DeviceSelectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
