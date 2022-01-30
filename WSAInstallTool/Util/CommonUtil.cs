using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WSAInstallTool.Util
{
    class CommonUtil
    {
        public static long GetCurrentTimeStamps()
        {
            TimeSpan ts = DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalMilliseconds);
        }

        /// <summary>
        /// Json字符串转内存对象
        /// </summary>
        /// <param name="jsonString"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T JsonToObject<T>(string jsonString)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
            MemoryStream mStream = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
            return (T)serializer.ReadObject(mStream);
        }

        /// <summary>
        /// 获取exe启动的目录
        /// </summary>
        /// <returns>D:\test</returns>
        public static string GetCurrentStartupPath()
        {
            return System.Windows.Forms.Application.StartupPath;
        }

        /// <summary>
        /// 在线程中初始化本地黑名单
        /// </summary>
        public static void InitBlackListBackground()
        {
            // 根据配置更新列表
            if (!PreferenceUtil.Instance.GetScanBadApk())
            {
                return;
            }
            ThreadStart ts = new ThreadStart(InitBlackList);
            Thread t = new Thread(ts);
            t.Start();
        }

        public static bool IsBadApk(string packageName, string hash)
        {
            // 根据配置更新列表
            byte[] csp = System.Text.Encoding.UTF8.GetBytes(GetCurrentStartupPath());
            byte[] pn = System.Text.Encoding.UTF8.GetBytes(packageName);
            return IsBadApk(csp, pn, hash);
        }

        [DllImport("BadApk.dll", EntryPoint = "is_bad_apk", CallingConvention = CallingConvention.Cdecl)]
        private extern static bool IsBadApk(byte[] runPath, byte[] packageName, string hash);

        [DllImport("BadApk.dll", EntryPoint = "init_black_list", CallingConvention = CallingConvention.Cdecl)]
        private extern static void InitBlackList(byte[] runPath);

        [DllImport("BadApk.dll", EntryPoint = "test", CallingConvention = CallingConvention.Cdecl)]
        private extern static void test(byte[] runPath);

        /// <summary>
        /// 初始化本地黑名单
        /// </summary>
        private static void InitBlackList()
        {
            Debug.WriteLine("[CommonUtil][InitBlackList] start..." + GetCurrentStartupPath());
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(GetCurrentStartupPath());
            InitBlackList(bs);
        }
    }
}
