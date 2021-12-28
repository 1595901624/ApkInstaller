using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;
using WSAInstallTool.Util;
using System.Diagnostics;

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
            if (args.Length == 0)
            {
                LangUtil.Instance.Init();
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
