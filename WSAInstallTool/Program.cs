using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;

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
            if (args.Length == 0)
            {
                //if (!IsAdministrator())
                //{
                //    MessageBox.Show("部分设置项需要操作注册表，请使用管理员身份运行此APP！");
                //    return;
                //}
                Application.Run(new SettingForm());
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
