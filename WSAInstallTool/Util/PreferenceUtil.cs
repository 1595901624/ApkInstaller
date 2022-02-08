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
    /// 获取设置
    /// </summary>
    class PreferenceUtil
    {
        public const string INSTALL_SECTION = "install";
        public const string LANG_SECTION = "lang";
        public const string OTHER_SECTION = "other";

        // 安装方式 1：覆盖安装 2：降级覆盖安装
        public const string INSTALL_METHOD = "installMethod";

        // 安装成功后是否关闭窗口
        public const string INSTALL_SUCCESS_CLOSE = "installSuccessClose";

        // 默认语言
        public const string LANG_DEFAULT = "current";

        // 黑名单更新时间
        public const string UPDATE_BLACK_LIST_TIME = "updateBlackListTime";

        // 恶意软件检测功能
        public const String SCAN_BAD_APK = "scanBadApk";

        private static PreferenceUtil _instance = null;
        private static readonly object SyncObject = new object();

        private PreferenceUtil()
        {

        }

        public static PreferenceUtil Instance
        {
            get
            {
                lock (SyncObject)
                {
                    return _instance ?? (_instance = new PreferenceUtil());
                }
            }
        }

        /// <summary>
        /// 设置当前恶意APK检测的状态
        /// </summary>
        /// <param name="check"></param>
        public void SetScanBadApk(int check)
        {
            IniUtil.Instance.WriteSettingValue(OTHER_SECTION, SCAN_BAD_APK, check.ToString());
        }

        /// <summary>
        /// 获取当前恶意APK检测配置的状态
        /// </summary>
        /// <returns></returns>
        public bool GetScanBadApk()
        {
            string result = IniUtil.Instance.ReadSettingValue(OTHER_SECTION, SCAN_BAD_APK, "0");
            try
            {
                if ("1".Equals(result))
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                Debug.Write("[PreferenceUtil][GetScanBadApk] error => " + e.Message);
            }
            return false;
        }

        /// <summary>
        /// 定时更新黑名单
        /// </summary>
        /// <returns></returns>
        public void UpdateBlackListByTime()
        {
            try
            {
                // 根据配置更新列表
                if (!PreferenceUtil.Instance.GetScanBadApk())
                {
                    return;
                }

                string updateTimeStr = IniUtil.Instance.ReadSettingValue(OTHER_SECTION, UPDATE_BLACK_LIST_TIME, "0");
                long updateTime = long.Parse(updateTimeStr);
                if (CommonUtil.GetCurrentTimeStamps() - updateTime > 24 * 60 * 60 * 1000)
                {
                    // 更新时间超过一天，则更新黑名单
                    CommonUtil.InitBlackListBackground();
                    IniUtil.Instance.WriteSettingValue(OTHER_SECTION, UPDATE_BLACK_LIST_TIME, CommonUtil.GetCurrentTimeStamps().ToString());
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine("[PreferenceUtil][UpdateBlackListByTime] error:" + e.Message);
                // 解析时间错误，则强制更新黑名单
                CommonUtil.InitBlackListBackground();
                IniUtil.Instance.WriteSettingValue(OTHER_SECTION, UPDATE_BLACK_LIST_TIME, CommonUtil.GetCurrentTimeStamps().ToString());

            }
        }


        /// <summary>
        /// 设置当前语言
        /// </summary>
        /// <param name="id"></param>
        public void SetLanguage(int id)
        {
            IniUtil.Instance.WriteSettingValue(LANG_SECTION, LANG_DEFAULT, id.ToString());
        }

        public int GetLanguage()
        {
            string id = IniUtil.Instance.ReadSettingValue(LANG_SECTION, LANG_DEFAULT, "0");
            try
            {
                return int.Parse(id);
            }
            catch (Exception e)
            {
                Debug.WriteLine("[PreferenceUtil][Getlanguage] error => " + e.Message);
                return 0;
            }
        }

        /// <summary>
        /// 获取语言包列表
        /// </summary>
        /// <returns></returns>
        public List<SupportLanguage> GetLanguageList()
        {
            try
            {
                string currentLangId = IniUtil.Instance.ReadSettingValue(LANG_SECTION, LANG_DEFAULT, "0");
                int id = int.Parse(currentLangId);
                string json = System.IO.File.ReadAllText(CommonUtil.GetCurrentStartupPath() + @"\lang\lang.json");
                List<SupportLanguage> sls = CommonUtil.JsonToObject<List<SupportLanguage>>(json);
                Debug.WriteLine("[PreferenceUtil][GetLanguageList] lang size: " + sls.Count + ", currentLangId: " + id);
                return sls;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("[PreferenceUtil][GetLanguageList] error: " + ex.Message);
                var sl = new SupportLanguage();
                sl.name = "中国-简体中文";
                sl.id = 0;
                sl.file = "zh_CN.json";
                return new List<SupportLanguage>() { sl };
            }
        }

        /// <summary>
        /// 获取当前的语言包
        /// </summary>
        /// <returns></returns>
        public string GetCurrentLangPath()
        {
            try
            {
                string currentLangId = IniUtil.Instance.ReadSettingValue(LANG_SECTION, LANG_DEFAULT, "0");
                int id = int.Parse(currentLangId);
                string json = System.IO.File.ReadAllText(CommonUtil.GetCurrentStartupPath() + @"\lang\lang.json");
                List<SupportLanguage> sls = CommonUtil.JsonToObject<List<SupportLanguage>>(json);
                Debug.WriteLine("[PreferenceUtil][GetCurrentLang] lang size: " + sls.Count + ", currentLangId: " + id);
                foreach (var sl in sls)
                {
                    Debug.WriteLine("sl ... " + sl.ToString());
                    if (sl.id == id)
                    {
                        return CommonUtil.GetCurrentStartupPath() + @"\lang\" + sl.file;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("[PreferenceUtil][GetCurrentLang] error: " + ex.Message);
            }
            return CommonUtil.GetCurrentStartupPath() + @"\lang\zh_CN.json";
        }

        /// <summary>
        /// 获取安装方式
        /// </summary>
        /// <returns>1：覆盖安装 2：降级覆盖安装</returns>
        public InstallMethod GetInstallMethod()
        {
            string result = IniUtil.Instance.ReadSettingValue(INSTALL_SECTION, INSTALL_METHOD, "1");
            if ("2".Equals(result))
            {
                return InstallMethod.DEGRADED_OVERLAY;
            }
            return InstallMethod.OVERLAY;
        }

        /// <summary>
        /// 获取当前的安装命令
        /// </summary>
        /// <returns></returns>
        public string GetInstallMethodCommand()
        {
            if (GetInstallMethod() == InstallMethod.DEGRADED_OVERLAY)
            {
                return "-r -d";
            }

            return "-r";
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="method">1：覆盖安装 2：降级覆盖安装</param>
        public void SetInstallMethod(InstallMethod method)
        {
            IniUtil.Instance.WriteSettingValue(INSTALL_SECTION, INSTALL_METHOD, Convert.ToInt32(method).ToString());
        }

        /// <summary>
        /// 安装成功后是否关闭窗口
        /// </summary>
        /// <returns>默认不关闭窗口</returns>
        public bool IsCloseAfterInstalled()
        {
            string result = IniUtil.Instance.ReadSettingValue(INSTALL_SECTION, INSTALL_SUCCESS_CLOSE, "0");
            if ("1".Equals(result))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 设置在安装成功后，是否关闭窗口
        /// </summary>
        /// <param name="close">0:不关闭，1：关闭</param>
        public void SetCloseAfterInstalled(int close)
        {
            IniUtil.Instance.WriteSettingValue(INSTALL_SECTION, INSTALL_SUCCESS_CLOSE, close.ToString());
        }


        public enum InstallMethod
        {
            OVERLAY = 1,
            DEGRADED_OVERLAY = 2
        }
    }
}
