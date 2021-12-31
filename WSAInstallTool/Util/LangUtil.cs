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

        public string GetLanguageSettingTitle() { return mAppString.languageSettingTitle ?? "语言设置"; }

        public string GetSelectLanguage() { return mAppString.selectLanguage ?? "选择语言"; }

        public string GetSelectLanguageTip() { return mAppString.selectLanguageTip ?? "注：语言选择后需要下一次生效"; }

        // 以下是权限翻译
        public string GetACCESS_COARSE_LOCATION() { return mAppString.LANG_ACCESS_COARSE_LOCATION ?? "通过WiFi或移动基站的方式获取用户粗略的经纬度信息，定位精度大概误差在30~1500米"; }
        public string GetACCESS_FINE_LOCATION() { return mAppString.LANG_ACCESS_FINE_LOCATION ?? "通过GPS芯片接收卫星的定位信息，定位精度达10米以内"; }
        public string GetACCESS_LOCATION_EXTRA_COMMANDS() { return mAppString.LANG_ACCESS_LOCATION_EXTRA_COMMANDS ?? "允许程序访问额外的定位提供者指令"; }
        public string GetACCESS_MOCK_LOCATION() { return mAppString.LANG_ACCESS_MOCK_LOCATION ?? "获取模拟定位信息，一般用于帮助开发者调试应用"; }
        public string GetACCESS_NETWORK_STATE() { return mAppString.LANG_ACCESS_NETWORK_STATE ?? "获取网络信息状态，如当前的网络连接是否有效"; }
        public string GetACCESS_SURFACE_FLINGER() { return mAppString.LANG_ACCESS_SURFACE_FLINGER ?? "Android平台上底层的图形显示支持，一般用于游戏或照相机预览界面和底层模式的屏幕截图"; }
        public string GetACCESS_WIFI_STATE() { return mAppString.LANG_ACCESS_WIFI_STATE ?? "获取当前WiFi接入的状态以及WLAN热点的信息"; }
        public string GetBATTERY_STATS() { return mAppString.LANG_BATTERY_STATS ?? "获取电池电量统计信息"; }
        public string GetBLUETOOTH() { return mAppString.LANG_BLUETOOTH ?? "允许程序连接配对过的蓝牙设备"; }
        public string GetBLUETOOTH_ADMIN() { return mAppString.LANG_BLUETOOTH_ADMIN ?? "允许程序进行发现和配对新的蓝牙设备"; }
        public string GetBRICK() { return mAppString.LANG_BRICK ?? "【危险权限】能够禁止使用手机"; }
        public string GetBROADCAST_PACKAGE_REMOVED() { return mAppString.LANG_BROADCAST_PACKAGE_REMOVED ?? "当一个应用在删除时触发一个广播"; }
        public string GetBROADCAST_SMS() { return mAppString.LANG_BROADCAST_SMS ?? "当收到短信时触发一个广播"; }
        public string GetBROADCAST_STICKY() { return mAppString.LANG_BROADCAST_STICKY ?? "允许一个程序收到广播后快速收到下一个广播"; }
        public string GetBROADCAST_WAP_PUSH() { return mAppString.LANG_BROADCAST_WAP_PUSH ?? "WAP PUSH服务收到后触发一个广播"; }
        public string GetCALL_PHONE() { return mAppString.LANG_CALL_PHONE ?? "允许程序从非系统拨号器里输入电话号码"; }
        public string GetCALL_PRIVILEGED() { return mAppString.LANG_CALL_PRIVILEGED ?? "允许程序拨打电话，替换系统的拨号器界面"; }
        public string GetCAMERA() { return mAppString.LANG_CAMERA ?? "允许访问摄像头进行拍照"; }
        public string GetCHANGE_CONFIGURATION() { return mAppString.LANG_CHANGE_CONFIGURATION ?? "允许当前应用改变配置，如定位"; }
        public string GetCHANGE_NETWORK_STATE() { return mAppString.LANG_CHANGE_NETWORK_STATE ?? "改变网络状态如是否能联网"; }
        public string GetCHANGE_WIFI_MULTICAST_STATE() { return mAppString.LANG_CHANGE_WIFI_MULTICAST_STATE ?? "改变WiFi多播状态"; }
        public string GetCHANGE_WIFI_STATE() { return mAppString.LANG_CHANGE_WIFI_STATE ?? "改变WiFi状态"; }
        public string GetCLEAR_APP_CACHE() { return mAppString.LANG_CLEAR_APP_CACHE ?? "清除应用缓存"; }
        public string GetCLEAR_APP_USER_DATA() { return mAppString.LANG_CLEAR_APP_USER_DATA ?? "清除应用的用户数据"; }
        public string GetCONTROL_LOCATION_UPDATES() { return mAppString.LANG_CONTROL_LOCATION_UPDATES ?? "允许获得移动网络定位信息改变"; }
        public string GetDELETE_CACHE_FILES() { return mAppString.LANG_DELETE_CACHE_FILES ?? "允许应用删除缓存文件"; }
        public string GetDELETE_PACKAGES() { return mAppString.LANG_DELETE_PACKAGES ?? "允许程序删除应用"; }
        public string GetDEVICE_POWER() { return mAppString.LANG_DEVICE_POWER ?? "允许访问底层电源管理"; }
        public string GetDIAGNOSTIC() { return mAppString.LANG_DIAGNOSTIC ?? "允许程序到RW到诊断资源"; }
        public string GetDISABLE_KEYGUARD() { return mAppString.LANG_DISABLE_KEYGUARD ?? "允许程序禁用键盘锁"; }
        public string GetDUMP() { return mAppString.LANG_DUMP ?? "允许程序获取系统dump信息并转存"; }
        public string GetEXPAND_STATUS_BAR() { return mAppString.LANG_EXPAND_STATUS_BAR ?? "允许程序扩展或收缩状态栏"; }
        public string GetFACTORY_TEST() { return mAppString.LANG_FACTORY_TEST ?? "允许程序运行工厂测试模式"; }
        public string GetFLASHLIGHT() { return mAppString.LANG_FLASHLIGHT ?? "允许访问闪光灯"; }
        public string GetFORCE_BACK() { return mAppString.LANG_FORCE_BACK ?? "允许程序强制使用back后退按键，无论页面是否在顶层"; }
        public string GetGET_PACKAGE_SIZE() { return mAppString.LANG_GET_PACKAGE_SIZE ?? "获取应用的文件大小"; }
        public string GetGET_TASKS() { return mAppString.LANG_GET_TASKS ?? "允许程序获取当前或最近运行的应用"; }
        public string GetGLOBAL_SEARCH() { return mAppString.LANG_GLOBAL_SEARCH ?? "允许程序使用全局搜索功能"; }
        public string GetHARDWARE_TEST() { return mAppString.LANG_HARDWARE_TEST ?? "访问硬件辅助设备，用于硬件测试"; }
        public string GetINJECT_EVENTS() { return mAppString.LANG_INJECT_EVENTS ?? "允许访问本程序的底层事件，获取按键、轨迹球的事件流"; }
        public string GetINSTALL_LOCATION_PROVIDER() { return mAppString.LANG_INSTALL_LOCATION_PROVIDER ?? "安装定位提供"; }
        public string GetINSTALL_PACKAGES() { return mAppString.LANG_INSTALL_PACKAGES ?? "允许程序安装应用"; }
        public string GetINTERNAL_SYSTEM_WINDOW() { return mAppString.LANG_INTERNAL_SYSTEM_WINDOW ?? "允许程序打开内部窗口，不对第三方应用程序开放此权限"; }
        public string GetINTERNET() { return mAppString.LANG_INTERNET ?? "访问网络连接，可能产生GPRS流量"; }
        public string GetKILL_BACKGROUND_PROCESSES() { return mAppString.LANG_KILL_BACKGROUND_PROCESSES ?? "允许程序调用killBackgroundProcesses(String)方法结束后台进程"; }
        public string GetMANAGE_ACCOUNTS() { return mAppString.LANG_MANAGE_ACCOUNTS ?? "允许程序管理AccountManager中的账户列表"; }
        public string GetMANAGE_APP_TOKENS() { return mAppString.LANG_MANAGE_APP_TOKENS ?? "管理创建、摧毁、Z轴顺序，仅用于系统"; }
        public string GetMTWEAK_USER() { return mAppString.LANG_MTWEAK_USER ?? "允许mTweak用户访问高级系统权限"; }
        public string GetMTWEAK_FORUM() { return mAppString.LANG_MTWEAK_FORUM ?? "允许使用mTweak社区权限"; }
        public string GetMASTER_CLEAR() { return mAppString.LANG_MASTER_CLEAR ?? "允许程序执行软格式化，删除系统配置信息"; }
        public string GetMODIFY_AUDIO_SETTINGS() { return mAppString.LANG_MODIFY_AUDIO_SETTINGS ?? "修改声音设置信息"; }
        public string GetMODIFY_PHONE_STATE() { return mAppString.LANG_MODIFY_PHONE_STATE ?? "修改电话状态，如飞行模式，但不包含替换系统拨号器界面"; }
        public string GetMOUNT_FORMAT_FILESYSTEMS() { return mAppString.LANG_MOUNT_FORMAT_FILESYSTEMS ?? "格式化可移动文件系统，比如格式化清空SD卡"; }
        public string GetMOUNT_UNMOUNT_FILESYSTEMS() { return mAppString.LANG_MOUNT_UNMOUNT_FILESYSTEMS ?? "挂载、反挂载外部文件系统"; }
        public string GetNFC() { return mAppString.LANG_NFC ?? "允许程序执行NFC近距离通讯操作，用于移动支持"; }
        public string GetPERSISTENT_ACTIVITY() { return mAppString.LANG_PERSISTENT_ACTIVITY ?? "创建一个永久的Activity，该功能标记为将来将被移除"; }
        public string GetPROCESS_OUTGOING_CALLS() { return mAppString.LANG_PROCESS_OUTGOING_CALLS ?? "允许程序监视，修改或放弃播出电话"; }
        public string GetREAD_CALENDAR() { return mAppString.LANG_READ_CALENDAR ?? "允许程序读取用户的日程信息"; }
        public string GetREAD_CONTACTS() { return mAppString.LANG_READ_CONTACTS ?? "允许应用访问联系人通讯录信息"; }
        public string GetREAD_FRAME_BUFFER() { return mAppString.LANG_READ_FRAME_BUFFER ?? "读取帧缓存用于屏幕截图"; }
        public string GetREAD_HISTORY_BOOKMARKS() { return mAppString.LANG_READ_HISTORY_BOOKMARKS ?? "读取浏览器收藏夹和历史记录"; }
        public string GetREAD_INPUT_STATE() { return mAppString.LANG_READ_INPUT_STATE ?? "读取当前键的输入状态，仅用于系统"; }
        public string GetREAD_LOGS() { return mAppString.LANG_READ_LOGS ?? "读取系统底层日志"; }
        public string GetREAD_PHONE_STATE() { return mAppString.LANG_READ_PHONE_STATE ?? "访问电话状态"; }
        public string GetREAD_SMS() { return mAppString.LANG_READ_SMS ?? "读取短信内容"; }
        public string GetREAD_EXTERNAL_STORAGE() { return mAppString.LANG_READ_EXTERNAL_STORAGE ?? "允许程序读取内部存储"; }
        public string GetREAD_SYNC_SETTINGS() { return mAppString.LANG_READ_SYNC_SETTINGS ?? "读取同步设置，读取Google在线同步设置"; }
        public string GetREAD_SYNC_STATS() { return mAppString.LANG_READ_SYNC_STATS ?? "读取同步状态，获得Google在线同步状态"; }
        public string GetREBOOT() { return mAppString.LANG_REBOOT ?? "允许程序重新启动设备"; }
        public string GetRECEIVE_BOOT_COMPLETED() { return mAppString.LANG_RECEIVE_BOOT_COMPLETED ?? "允许程序开机自动运行"; }
        public string GetRECEIVE_MMS() { return mAppString.LANG_RECEIVE_MMS ?? "接收彩信"; }
        public string GetRECEIVE_SMS() { return mAppString.LANG_RECEIVE_SMS ?? "接收短信"; }
        public string GetRECEIVE_WAP_PUSH() { return mAppString.LANG_RECEIVE_WAP_PUSH ?? "接收WAP PUSH信息"; }
        public string GetRECORD_AUDIO() { return mAppString.LANG_RECORD_AUDIO ?? "录制声音通过手机或耳机的麦克"; }
        public string GetREORDER_TASKS() { return mAppString.LANG_REORDER_TASKS ?? "重新排序系统Z轴运行中的任务"; }
        public string GetRESTART_PACKAGES() { return mAppString.LANG_RESTART_PACKAGES ?? "结束任务通过restartPackage(String)方法，该方式将在外来放弃"; }
        public string GetSEND_SMS() { return mAppString.LANG_SEND_SMS ?? "发送短信"; }
        public string GetSET_ACTIVITY_WATCHER() { return mAppString.LANG_SET_ACTIVITY_WATCHER ?? "设置Activity观察器一般用于monkey测试"; }
        public string GetSET_ALARM() { return mAppString.LANG_SET_ALARM ?? "设置闹铃提醒"; }
        public string GetSET_ALWAYS_FINISH() { return mAppString.LANG_SET_ALWAYS_FINISH ?? "设置程序在后台是否总是退出"; }
        public string GetSET_ANIMATION_SCALE() { return mAppString.LANG_SET_ANIMATION_SCALE ?? "设置全局动画缩放"; }
        public string GetSET_DEBUG_APP() { return mAppString.LANG_SET_DEBUG_APP ?? "设置调试程序，一般用于开发"; }
        public string GetSET_ORIENTATION() { return mAppString.LANG_SET_ORIENTATION ?? "设置屏幕方向为横屏或标准方式显示，不用于普通应用"; }
        public string GetSET_PREFERRED_APPLICATIONS() { return mAppString.LANG_SET_PREFERRED_APPLICATIONS ?? "设置应用的参数,已不再工作,具体查看addPackageToPreferred(String)介绍"; }
        public string GetSET_PROCESS_LIMIT() { return mAppString.LANG_SET_PROCESS_LIMIT ?? "允许程序设置最大的进程数量的限制"; }
        public string GetSET_TIME() { return mAppString.LANG_SET_TIME ?? "设置系统时间"; }
        public string GetSET_TIME_ZONE() { return mAppString.LANG_SET_TIME_ZONE ?? "设置系统时区"; }
        public string GetSET_WALLPAPER() { return mAppString.LANG_SET_WALLPAPER ?? "设置桌面壁纸"; }
        public string GetSET_WALLPAPER_HINTS() { return mAppString.LANG_SET_WALLPAPER_HINTS ?? "设置壁纸建议"; }
        public string GetSIGNAL_PERSISTENT_PROCESSES() { return mAppString.LANG_SIGNAL_PERSISTENT_PROCESSES ?? "发送一个永久的进程信号"; }
        public string GetSTATUS_BAR() { return mAppString.LANG_STATUS_BAR ?? "允许程序打开、关闭、禁用状态栏"; }
        public string GetSUBSCRIBED_FEEDS_READ() { return mAppString.LANG_SUBSCRIBED_FEEDS_READ ?? "访问订阅信息的数据库"; }
        public string GetSUBSCRIBED_FEEDS_WRITE() { return mAppString.LANG_SUBSCRIBED_FEEDS_WRITE ?? "写入或修改订阅内容的数据库"; }
        public string GetSYSTEM_ALERT_WINDOW() { return mAppString.LANG_SYSTEM_ALERT_WINDOW ?? "显示系统窗口"; }
        public string GetUPDATE_DEVICE_STATS() { return mAppString.LANG_UPDATE_DEVICE_STATS ?? "更新设备状态"; }
        public string GetUSE_CREDENTIALS() { return mAppString.LANG_USE_CREDENTIALS ?? "允许程序请求验证从AccountManager"; }
        public string GetUSE_SIP() { return mAppString.LANG_USE_SIP ?? "允许程序使用SIP视频服务"; }
        public string GetVIBRATE() { return mAppString.LANG_VIBRATE ?? "允许振动"; }
        public string GetWAKE_LOCK() { return mAppString.LANG_WAKE_LOCK ?? "允许程序在手机屏幕关闭后后台进程仍然运行"; }
        public string GetWRITE_APN_SETTINGS() { return mAppString.LANG_WRITE_APN_SETTINGS ?? "写入网络GPRS接入点设置"; }
        public string GetWRITE_CALENDAR() { return mAppString.LANG_WRITE_CALENDAR ?? "写入日程，但不可读取"; }
        public string GetWRITE_CONTACTS() { return mAppString.LANG_WRITE_CONTACTS ?? "写入联系人，但不可读取"; }
        public string GetWRITE_EXTERNAL_STORAGE() { return mAppString.LANG_WRITE_EXTERNAL_STORAGE ?? "允许程序写入外部存储，如SD卡上写文件"; }
        public string GetWRITE_GSERVICES() { return mAppString.LANG_WRITE_GSERVICES ?? "允许程序写入Google Map服务数据"; }
        public string GetWRITE_HISTORY_BOOKMARKS() { return mAppString.LANG_WRITE_HISTORY_BOOKMARKS ?? "写入浏览器历史记录或收藏夹，但不可读取"; }
        public string GetWRITE_SECURE_SETTINGS() { return mAppString.LANG_WRITE_SECURE_SETTINGS ?? "允许程序读写系统安全敏感的设置项"; }
        public string GetWRITE_SETTINGS() { return mAppString.LANG_WRITE_SETTINGS ?? "允许读写系统设置项"; }
        public string GetWRITE_SMS() { return mAppString.LANG_WRITE_SMS ?? "允许编写短信"; }
        public string GetWRITE_SYNC_SETTINGS() { return mAppString.LANG_WRITE_SYNC_SETTINGS ?? "写入Google在线同步设置"; }


    }
}
