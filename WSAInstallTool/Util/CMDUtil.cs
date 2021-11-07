using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WSAInstallTool
{
    class CMDUtil
    {
        //执行命令行命令,获取输出结果
        //cmd_filename: DOS程序文件名
        //arguments: 命令行参数
        public static string ExecCMD(string cmd_filename, string arguments)
        {
            ProcessStartInfo psi = new ProcessStartInfo(cmd_filename, arguments);//如：调用ipconfig ,并传入参数: /all 
            psi.CreateNoWindow = true; //若为false，则会出现cmd的黑窗体 
            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;
            psi.StandardOutputEncoding = Encoding.UTF8;
            System.Diagnostics.Process p = System.Diagnostics.Process.Start(psi);
            return p.StandardOutput.ReadToEnd();
        }

        /// <summary>
        /// 执行bat文件
        /// </summary>
        /// <param name="batName"></param>
        public static void ExecBat(string batName)
        {
            //Process process = new Process();
            //process.StartInfo.FileName = batName;
            //process.Start();
            //cmd为想要执行的进程名，workingDir为它的所在路径，如果在windows\system32可以为空
            var pStartInfo = new System.Diagnostics.ProcessStartInfo(batName);
            pStartInfo.Verb = "runas";//设置该启动动作，会以管理员权限运行进程
            pStartInfo.CreateNoWindow = false;
            pStartInfo.UseShellExecute = true;
            pStartInfo.RedirectStandardError = false;
            pStartInfo.RedirectStandardInput = false;
            pStartInfo.RedirectStandardOutput = false;
            Process.Start(pStartInfo);
            //Process.Start(@"D:\项目目录\WSAInstallTool\WSAInstallTool\bin\Debug\install.bat");

        }
    }
}
