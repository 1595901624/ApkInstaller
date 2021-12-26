using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WSAInstallTool.Util
{
    /// <summary>
    /// 获取设置
    /// </summary>
    class PreferenceUtil
    {
        public const string INSTALL_SECTION = "install";

        // 安装方式 1：覆盖安装 2：降级覆盖安装
        public const string INSTALL_METHOD = "installMethod";

        // 安装成功后是否关闭窗口
        public const string INSTALL_SUCCESS_CLOSE = "installSuccessClose";

        private static PreferenceUtil _instance = null;
        private static readonly object SyncObject = new object();

        private PreferenceUtil()
        {
 
        }

        public static PreferenceUtil Instance
        {
            get {
                lock(SyncObject)
                {
                    return _instance ?? (_instance = new PreferenceUtil());
                }
            }
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
