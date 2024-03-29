﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;
using WSAInstallTool.Util;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace WSAInstallTool
{
    static class Program
    {

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IniUtil.Instance.Init();
            LangUtil.Instance.Init();
            // 更新黑名单
            PreferenceUtil.Instance.UpdateBlackListByTime();
            //Application.Run(new InstallForm(args));
            if (args.Length == 0)
            {
                if (!IsAdministrator())
                {
                    MessageBox.Show(LangUtil.Instance.GetLauncherTip(), "Apk Installer", MessageBoxButtons.OK);
                    return;
                }
                Application.Run(new MainForm());
                //Application.Run(new InstallForm(args));
            }
            else
            {
                Application.Run(new InstallForm(args));
            }


        }

        public static bool IsAdministrator()
        {
            WindowsIdentity current = WindowsIdentity.GetCurrent();
            WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
            return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }   
}
