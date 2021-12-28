using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSAInstallTool.AppModel;

namespace WSAInstallTool.Util
{
    /// <summary>
    /// 语言管理工具
    /// </summary>
    class LangUtil
    {
        private static LangUtil _instance = null;
        private static readonly object SyncObject = new object();

        private const string MAIN_SECTION = "main";
        private const string LAUNCH_TIP = "launchTip";

        private AppString mAppString = new AppString();

        private LangUtil()
        {
 
        }

        public static LangUtil Instance
        {
            get {
                lock(SyncObject)
                {
                    return _instance ?? (_instance = new LangUtil());
                }
            }
        }

        public void Init()
        {
            try
            {
                string json = System.IO.File.ReadAllText(PreferenceUtil.Instance.GetCurrentLangPath());
                Debug.WriteLine("[LangUtil][Init] lang json:" + json);
                mAppString = CommonUtil.JsonToObject<AppString>(json);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("[LangUtil][Init] error = " +ex.Message);
                mAppString = new AppString();
            }
        }


        /// <summary>
        /// 启动提示
        /// </summary>
        /// <returns></returns>
        public string GetLauncherTip()
        {
            return mAppString.launchTip ?? "部分设置项需要操作注册表，请使用管理员身份运行此软件！";
        }

        public string GetOk()
        {
            return mAppString.ok ?? "确定";
        }

        public string GetAssociateApk()
        {
            return mAppString.associateApk ?? "关联APK";
        }

        public string GetOneKeyInstall()
        {
            return mAppString.oneKeyInstall ?? "一键安装";
        }

        public string GetOnKeyUninstall()
        {
            return mAppString.oneKeyUninstall ?? "卸载软件/清除旧版本";
        }

        public string GetAbout()
        {
            return mAppString.about ?? "关于";
        }

        public string GetReadMe()
        {
            return mAppString.readMe ?? "使用前必读";
        }
    }
}
