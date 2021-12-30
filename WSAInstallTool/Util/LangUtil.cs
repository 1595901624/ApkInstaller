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
            get
            {
                lock (SyncObject)
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
                Debug.WriteLine("[LangUtil][Init] error = " + ex.Message);
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

        public string GetInstallFinished()
        {
            return mAppString.installFinished ?? "安装完成！";
        }

        public string GetUninstallFinished()
        {
            return mAppString.uninstallFinished ?? "清除完成！请直接删除软件所在目录即可！";
        }

        public string GetReadMeMessageTip()
        {
            string s = "1、点击“一键安装”将会自动关联APK文件，并且显示APK自身应用图标\n"
                + "2、点击“一键清除”将会自动解关联APK文件，并且解除显示APK自身应用图标\n"
                + "3、点击“一键清除”后如果依然显示APK图标是由于电脑软件的原因，重启电脑即可解决\n"
                + "4、卸载软件：请先点击“一键清除”，然后直接删除软件所在目录即可。";
            return mAppString.readMeMessageTip ?? s;
        }

        public string GetPackageName()
        {
            return mAppString.packageName ?? "包名：";
        }

        public string GetVersionName()
        {
            return mAppString.versionName ?? "版本名称：";
        }

        public string GetMinVersionName()
        {
            return mAppString.minVersionName ?? "最低支持版本：";
        }

        public string GetPersimissions()
        {
            return mAppString.permissions ?? "权限：";
        }

        public string GetSize()
        {
            return mAppString.size ?? "大小：";
        }

        public string GetNoAnyAndroidDevice()
        {
            return mAppString.noAnyAndroidDevice ?? "没有检测到任何安卓设备！";
        }

        public string GetAppInstalling()
        {
            return mAppString.appInstalling ?? "安装中...";
        }

        public string GetAppInstall()
        {
            return mAppString.appInstall ?? "安装";
        }

        public string GetAppInstallSuccess()
        {
            return mAppString.appInstallSuccess ?? "安装成功！";
        }

        public string GetAppInstallFailedDowngrade()
        {
            return mAppString.appInstallFailedDowngrade ?? "安装失败：检测到当前安装版本低于设备中已安装的版本。\n如果需要强制安装，请到设置页勾选“降级覆盖安装”！";
        }

        public string GetAppInstallFailed()
        {
            return mAppString.appInstallFailed ?? "安装失败：";
        }

        public string GetAppUnknown()
        {
            return mAppString.appUnknown ?? "未知";
        }

        public string GetViewMorePermissions()
        {
            return mAppString.viewMorePermissions ?? "查看更多权限";
        }

        public string GetInstallFromTitle()
        {
            return mAppString.installFormTitle ?? "安装 Apk";
        }

        public string GetNothing()
        {
            return mAppString.nothing ?? "无";
        }

        public string GetUnrecognizedVersion()
        {
            return mAppString.unrecognizedVersion ?? "无法识别的版本";
        }

        public string GetDeviceSelectFormTitle()
        {
            return mAppString.deviceSelectFormTitle ?? "选择安装的设备";
        }

        public string GetDeviceSelectTIp()
        {
            return mAppString.deviceSelectTip ?? "发现多款安卓设备，请选择要安装的设备：";
        }

        public string GetConfirmInstall()
        {
            return mAppString.confirmInstall ?? "确定安装";
        }

        public string GetPermissionFormTitle()
        {
            return mAppString.permissionFormTitle ?? "所有权限";
        }

        public string GetColumnNumber()
        {
            return mAppString.columnNumber ?? "序号";
        }

        public string GetColumnPermission()
        {
            return mAppString.columnPermission ?? "权限";
        }

        public string GetSettingFormTitle() { return mAppString.settingFormTitle ?? "偏好设置"; }

        public string GetInstallSettingTabTitle() { return mAppString.installSettingTabTitle ?? "Apk安装设置"; }

        public string GetAfterInstallSuccessClose() { return mAppString.afterInstallSuccessClose ?? "安装成功后自动关闭窗口"; }

        public string GetInstallMethod() { return mAppString.installMethod ?? "安装方式："; }

        public string GetOverlayInstall() { return mAppString.overlayInstall ?? "覆盖安装"; }

        public string GetDowngradeOverlayInsall() { return mAppString.downgradeOverlayInsall ?? "降级覆盖安装"; }

        public string GetSettingFormBottomTip() { return mAppString.settingFormBottomTip ?? "注：该页面下的所有设置全局生效。"; }



    }
}
