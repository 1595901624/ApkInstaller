using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WSAInstallTool
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

         /// <summary>
        /// 关联APK
        /// </summary>
        private void associatedApk()
        {
            // 判断.apk项是否存在
            if (IsRegistryKeyExist(".apk"))
            {
                // 删除.apk的相关信息
                Console.WriteLine("exist!!!");
                DeleteClassesRootRegistryKey(".apk");

            }
            // 创建
            CreateAssociationProgram();
        }

        /// <summary>
        /// 创建关联程序
        /// </summary>
        private void CreateAssociationProgram()
        {
            // 默认 Apkdb.apk
            //主要用到了SetValue()，表示在test下创建名称为Name，值为RegistryTest的键值。第三个参数表示键值类型，省略时，默认为字符串
            // 1.设置打开APK扩展名的软件
            RegistryKey hklm = Registry.ClassesRoot;
            RegistryKey hkSoftWare = hklm.CreateSubKey(@"HYWINXYZWSATOOL\shell\open\command");
            string softwarePath = System.Threading.Thread.GetDomain().BaseDirectory;
            hkSoftWare.SetValue("", "\"" + softwarePath + "WSAInstallTool.exe\" \"%1\"", RegistryValueKind.String);
            
            // 2.创建.apk
            RegistryKey apkSoftWare = hklm.CreateSubKey(@".apk");
            apkSoftWare.SetValue("", "HYWINXYZWSATOOL", RegistryValueKind.String);
            hklm.Close();
            hkSoftWare.Close();
        }

        /// <summary>
        /// 删除已经存在的APK项
        /// </summary>
        private void DeleteClassesRootRegistryKey(string key)
        {
            //主要用到了DeleteSubKey()
            RegistryKey hklm = Registry.ClassesRoot;


            hklm.DeleteSubKeyTree(key, false);  //为true时，删除的注册表不存在时抛出异常；当为false时不抛出异常。
            hklm.Close();
        }

        /// <summary>
        /// 判断注册表项是否存在
        /// </summary>
        /// <param name="sKeyName"></param>
        /// <returns></returns>
        private bool IsRegistryKeyExist(string sKeyName)
        {
            string[] sKeyNameColl;
            RegistryKey hklm = Registry.ClassesRoot;
            sKeyNameColl = hklm.GetSubKeyNames(); 
            foreach (string sName in sKeyNameColl)
            {
                if (sName == sKeyName)
                {
                    hklm.Close();
                    return true;
                }
            }
            hklm.Close();
            return false;
        }

        private void installButton_Click(object sender, EventArgs e)
        {
            //1.设置关联APK文件
            associatedApk();
            CMDUtil.ExecBat("install.bat");
            MessageBox.Show("安装完成！");
        }

        private void uninstallButton_Click(object sender, EventArgs e)
        {
            CMDUtil.ExecBat("uninstall.bat");
            RegistryKey hklm = Registry.ClassesRoot;
            hklm.DeleteSubKeyTree(".apk", false);  //为true时，删除的注册表不存在时抛出异常；当为false时不抛出异常。
            hklm.DeleteSubKeyTree("HYWINXYZWSATOOL", false);
            //hklm.DeleteSubKey(@"HYWINXYZWSATOOL\shell\open\command", false);
            //hklm.DeleteSubKey(@"HYWINXYZWSATOOL\shell\open", false);
            //hklm.DeleteSubKey(@"HYWINXYZWSATOOL\shell", false);
            //hklm.DeleteSubKey(@"HYWINXYZWSATOOL", false);
           
            hklm.Close();
            MessageBox.Show("清除完成！请直接删除软件所在目录即可！");   
        }

        private void aboutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }

        /// <summary>
        /// 安装APK图标点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void installApkIconButton_Click(object sender, EventArgs e)
        {
            //2.显示自身APK图标
            CMDUtil.ExecBat("install.bat");
        }

        private void uninsallApkIconButton_Click(object sender, EventArgs e)
        {
            CMDUtil.ExecBat("uninstall.bat");
            associatedApk();
        }

        private void readMeLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string s = "1、点击“一键安装”将会自动关联APK文件，并且显示APK自身应用图标\n"
                + "2、点击“一键清除”将会自动解关联APK文件，并且解除显示APK自身应用图标\n"
                + "3、点击“一键清除”后如果依然显示APK图标是由于电脑软件的原因，重启电脑即可解决\n"
                + "4、卸载软件：请先点击“一键清除”，然后直接删除软件所在目录即可。";
            MessageBox.Show(s);
        }
    }
}
