using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WSAInstallTool.Util
{
    class IniUtil
    {


        //读写INI文件的API函数
        [DllImport("kernel32", CharSet = CharSet.Auto)]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32", CharSet = CharSet.Auto)]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        // 配置项
        private const string SETTING_PATH = "setting.ini";
        private string ABSOLUTE_SETTING_PATH = "";
        
        // 语言文件(预留)
        private const string LANGUAGE_PATH = "";

        private static IniUtil _instance = null;
        private static readonly object SyncObject = new object();
        
        private IniUtil()
        {
 
        }

        public static IniUtil Instance
        {
            get {
                lock(SyncObject)
                {
                    return _instance ?? (_instance = new IniUtil());
                }
            }
        }

        /// <summary>
        /// init方法，需要在程序启动时调用
        /// </summary>
        public void Init()
        {
            ABSOLUTE_SETTING_PATH = System.Windows.Forms.Application.StartupPath + "\\" + SETTING_PATH;
            if (!File.Exists(ABSOLUTE_SETTING_PATH))
            {
                Debug.WriteLine("not exist setting.ini");
                CreateIniFile(ABSOLUTE_SETTING_PATH);
            }
            
            Debug.WriteLine("[IniUtil][Init] setting path :" + ABSOLUTE_SETTING_PATH);
        }

        /// <summary>
        /// 读取偏好设置的值
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public string ReadSettingValue(string section, string key, string defaultValue)
        {
            string result = ReadIniValue(ABSOLUTE_SETTING_PATH, section, key, defaultValue);
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void WriteSettingValue(string section, string key, string value)
        {
            WriteIniValue(ABSOLUTE_SETTING_PATH, section, key, value);
        }

        /// <summary>
        /// 写INI文件
        /// </summary>
        /// <param name="path"></param>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        private void WriteIniValue(string path, string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, path);
        }

        /// <summary>
        /// 读取INI文件指定关键字的值
        /// </summary>
        /// <param name="path"></param>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        private string ReadIniValue(string path, string section, string key, string defaultValue)
        {
            try
            {
                StringBuilder sb = new StringBuilder(1024);
                int i = GetPrivateProfileString(section, key, "", sb, 1024, path);
                Debug.WriteLine("[IniUtil][ReadIniValue] get result = " + i);
                if (sb == null)
                {
                    return defaultValue;
                }
                string temp = sb.ToString();
                return String.IsNullOrEmpty(temp) ? defaultValue : temp.Trim();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("[IniUtil][ReadIniValue] error : " + ex.Message);
                return defaultValue;
            }
        }

        /// <summary>
        /// 创建ini文件
        /// </summary>
        private void CreateIniFile(string path)
        {
            StreamWriter w = File.CreateText(path);
            w.Write("");
            w.Flush();
            w.Close();
        }
    }
}
