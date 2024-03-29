﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSAInstallTool.Util;

namespace WSAInstallTool
{
    public partial class PermissionForm : Form
    {
        private List<string> permissionList = new List<string>();

        public PermissionForm(List<string> permissionList)
        {
            InitializeComponent();

            if (permissionList != null)
            {
                this.permissionList = permissionList;
            }
        }

        private void PermissionForm_Load(object sender, EventArgs e)
        {
            InitLanguage();
            permissionListView.BeginUpdate();
            //permissionListView.Columns.Add("序号");
            //permissionListView.Columns.Add("权限");

            for (int i = 0; i < permissionList.Count; i++)
            {
                var lvi = new ListViewItem();
                lvi.Text = (i + 1) + "";
                lvi.SubItems.Add(permissionList[i]);
                permissionListView.Items.Add(lvi);
            }
            permissionListView.EndUpdate();
        }

        private void InitLanguage()
        {
            this.Text = LangUtil.Instance.GetPermissionFormTitle();
            permissionListView.Columns[0].Text = LangUtil.Instance.GetColumnNumber();
            permissionListView.Columns[1].Text = LangUtil.Instance.GetColumnPermission();
        }
    }
}
