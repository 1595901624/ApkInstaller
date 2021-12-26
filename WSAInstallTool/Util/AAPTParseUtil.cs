using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using System.IO.Compression;
using System.IO;
using System.Diagnostics;

namespace WSAInstallTool
{
    class AAPTParseUtil
    {
        private string appInfo = "";
        private string[] appInfoList = null;

        public AAPTParseUtil(string appInfo)
        {
            if (appInfo == null || appInfo.Length == 0)
            {
                return;
            }
            this.appInfo = appInfo;
            this.appInfoList = appInfo.Split('\n');
            //Console.WriteLine(appInfoList.Length);
        }

        public string GetPackageName()
        {
            if (appInfo.Length == 0 || appInfoList.Length < 1) return "";

            return GetValue(appInfoList[0], "package: name='", "' versionCode='");
        }

        /// <summary>
        /// 获取版本名称
        /// </summary>
        /// <returns></returns>
        public string GetVersionName()
        {
            if (appInfo.Length == 0 || appInfoList.Length < 1) return "";

            return GetValue(appInfoList[0], "versionName='", "' compileSdkVersion='");
        }

        /// <summary>
        /// 获取详细的权限列表
        /// </summary>
        /// <returns></returns>
        public string GetPermissionDetail()
        {
            if (appInfo.Length == 0 || appInfoList.Length < 1) return "";
            StringBuilder sb = new StringBuilder();
            foreach (string str in appInfoList)
            {
                if (str.Contains("uses-permission:"))
                {
                    sb.Append(str).Append("\n");
                }
            }
            return sb.ToString().Trim();
        }

        /// <summary>
        /// 获取详细的权限信息解释 返回String
        /// </summary>
        /// <returns></returns>
        public string GetPermissionDetailString()
        {
            if (appInfo.Length == 0 || appInfoList.Length < 1) return "";

            StringBuilder sb = new StringBuilder();

            List<String> temp = GetPermissionList();

            foreach (String str in temp)
            {

                //if (str.Contains(AndroidPerimission.READ_EXTERNAL_STORAGE.permissionName))
                //{
                //    sb.Append(AndroidPerimission.READ_EXTERNAL_STORAGE.description).Append("\n");
                //}
                //Console.WriteLine("....." + AndroidPerimission.Values + "..." + str);
                foreach (AndroidPerimission permission in AndroidPerimission.Values)
                {
                    //Console.WriteLine("....." + permission.description);
                    //Console.WriteLine("....." + permission.permission);
                    if (str == permission.permission)
                    {
                        sb.Append("· ").Append(permission.description).Append("\n");
                    }
                }
            }

            return sb.ToString().Trim();
        }

        /// <summary>
        /// 获取详细的权限信息解释 返回List
        /// </summary>
        /// <returns></returns>
        public List<string> GetPermissionDetailList()
        {
            if (appInfo.Length == 0 || appInfoList.Length < 1) return new List<string>();

            List<string> result = new List<string>();

            List<String> temp = GetPermissionList();

            foreach (String str in temp)
            {
                foreach (AndroidPerimission permission in AndroidPerimission.Values)
                {
                    if (str == permission.permission)
                    {
                        result.Add(permission.description);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// 获取权限信息列表 返回List
        /// </summary>
        /// <returns>List<string></returns>
        public List<string> GetPermissionList()
        {
            if (appInfo.Length == 0 || appInfoList.Length < 1) return new List<string>();

            StringBuilder sb = new StringBuilder();

            List<String> temp = new List<String>();

            foreach (string str in appInfoList)
            {
                if (str.Contains("uses-permission: name='"))
                {
                    if (!temp.Contains(str))
                    {
                        temp.Add(GetValue(str, "uses-permission: name='", "'"));
                    }
                }
            }
            return temp;
        }

        /// <summary>
        /// 获取APK图标
        /// </summary>
        /// <param name="apkPath"></param>
        /// <returns></returns>
        public string GetApkIcon(string apkPath)
        {
            string result = System.Threading.Thread.GetDomain().BaseDirectory + "icon\\" + GetPackageName() + ".png";

            if (File.Exists(result))
            {
                //Console.WriteLine("logo exist！");
                return result;
            }
            try
            {
                //ZipFile.ExtractToDirectory(apkPath, "temp"); //解压
                string logoPath = "";
                // 1. 获取logo
                foreach (string str in appInfoList)
                {
                    if (str.Contains("application-icon-120"))
                    {
                        logoPath = GetValue(str.Trim(), "application-icon-120:'", "'");
                        break;
                    }
                }
                if (logoPath == null || logoPath.Length == 0) return "";
                string logoFileName = Path.GetFileName(logoPath);
                //Console.WriteLine("..." + logoPath);

                // 2. 解压logo
                using (ZipArchive zipArchive = ZipFile.Open(apkPath, ZipArchiveMode.Read))
                {
                    foreach (ZipArchiveEntry entry in zipArchive.Entries)
                    {

                        if (entry.Name == logoFileName)
                        {
                            //Console.WriteLine(entry.Name);
                            using (Stream stream = entry.Open())
                            {
                                if (!Directory.Exists(System.Threading.Thread.GetDomain().BaseDirectory + "icon"))
                                {
                                    Directory.CreateDirectory(System.Threading.Thread.GetDomain().BaseDirectory + "icon");
                                }
                                entry.ExtractToFile(result, true);
                            }
                        }
                    }
                }
                Debug.WriteLine("apk logo path => " + result);
                return result;
            }
            catch (Exception e)
            {
                Debug.WriteLine("get apk icon error! " + e.Message);
                return "";
            }
        }

        /// <summary>
        /// 获取APP名称
        /// </summary>
        /// <returns></returns>
        public string GetAppName()
        {
            if (appInfo.Length == 0 || appInfoList.Length < 1) return "";
            string zhName = "";
            string defaultName = "";
            foreach (string str in appInfoList)
            {
                if (str.Contains("application-label-zh:"))
                {

                    //return GetValue(str, "application-label:", "");
                    zhName = GetValue(str, "application-label-zh:'", "'");
                }
                else if (str.Contains("application-label:"))
                {
                    defaultName = GetValue(str, "application-label:'", "'");
                }
            }

            if (zhName != null && zhName != "" && zhName.Length != 0)
            {
                return Utf82Gb2312(zhName);
            }
            else if (defaultName != null && defaultName != "" && defaultName.Length != 0)
            {
                return defaultName;
            }
            return "";
        }

        public int GetMinSdkVersion()
        {
            if (appInfo.Length == 0 || appInfoList.Length < 1)
            {
                return -1;
            }

            foreach (string s in appInfoList)
            {
                if (s.Contains("sdkVersion:'"))
                {
                    try
                    {
                        var result = int.Parse(GetValue(s, "sdkVersion:'", "'"));
                        return result;
                    }
                    catch (Exception e)
                    {
                        Debug.WriteLine("GetMinSdkVersion Error! = " + e.Message);
                        return -1;
                    }
                }
            }

            return -1;
        }

        /// <summary>
        /// 获取最小支持的android版本
        /// </summary>
        /// <returns></returns>
        public string getMinSupportVersion()
        {
            int minSdk = GetMinSdkVersion();
            if (minSdk == -1)
            {
                return "无法识别的版本";
            }
            foreach (AndroidSDKVersion sdkVersion in AndroidSDKVersion.Values)
            {
                if (sdkVersion.api == minSdk)
                {
                    return "Android " + sdkVersion.version;
                }
            }
            return "无法识别的版本";
        }

        /// <summary>
        /// 获得字符串中开始和结束字符串中间得值
        /// </summary>
        /// <param name="str">字符串</param>
        /// <param name="s">开始</param>
        /// <param name="e">结束</param>
        /// <returns></returns>
        public string GetValue(string str, string s, string e)
        {
            Regex rg = new Regex("(?<=(" + s + "))[.\\s\\S]*?(?=(" + e + "))", RegexOptions.Multiline | RegexOptions.Singleline);
            return rg.Match(str).Value;
        }

        /// <summary>
        /// UTF8转换成GB2312
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string Utf82Gb2312(string text)
        {
            //声明字符集   
            System.Text.Encoding utf8, gb2312;
            //utf8   
            utf8 = System.Text.Encoding.GetEncoding("utf-8");
            //gb2312   
            gb2312 = System.Text.Encoding.GetEncoding("gb2312");
            byte[] utf;
            utf = utf8.GetBytes(text);
            utf = System.Text.Encoding.Convert(utf8, gb2312, utf);
            //返回转换后的字符   
            return gb2312.GetString(utf);
        }
    }
}
