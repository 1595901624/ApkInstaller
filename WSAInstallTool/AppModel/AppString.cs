using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WSAInstallTool.AppModel
{
    /// <summary>
    /// 应用所需的所有字符串
    /// </summary>
    [DataContractAttribute]
    class AppString
    {
        [DataMember]
        public string launchTip { set; get; }

        [DataMember]
        public string ok { set; get; }

        [DataMember]
        public string associateApk { set; get; }

        [DataMember]
        public string oneKeyInstall { set; get; }

        [DataMember]
        public string oneKeyUninstall { set; get; }

        [DataMember]
        public string about { set; get; }

        [DataMember]
        public string readMe { set; get; }

        [DataMember]
        public string installFinished { set; get; }

        [DataMember]
        public string uninstallFinished { set; get; }

        [DataMember]
        public string readMeMessageTip { set; get; }

        [DataMember]
        public string packageName { set; get; }

        [DataMember]
        public string versionName { set; get; }

        [DataMember]
        public string minVersionName { set; get; }

        [DataMember]
        public string size { set; get; }

        [DataMember]
        public string permissions { set; get; }

        [DataMember]
        public string viewMorePermissions { set; get; }

        [DataMember]
        public string noAnyAndroidDevice { set; get; }

        [DataMember]
        public string appInstalling { set; get; }

        [DataMember]
        public string appInstallSuccess { set; get; }

        [DataMember]
        public string appInstall { set; get; }

        [DataMember]
        public string appInstallFailedDowngrade { set; get; }

        [DataMember]
        public string appInstallFailed { set; get; }

        [DataMember]
        public string appUnknown { set; get; }

        [DataMember]
        public string installFormTitle { set; get; }

        [DataMember]
        public string nothing { set; get; }

        [DataMember]
        public string unrecognizedVersion { set; get; }

        [DataMember]
        public string deviceSelectFormTitle { set; get;}

        [DataMember]
        public string deviceSelectTip { set; get; }

        [DataMember]
        public string confirmInstall { set; get; }

        [DataMember]
        public string permissionFormTitle { set; get;}

        [DataMember]
        public string columnNumber { set; get; }

        [DataMember]
        public string columnPermission { set; get; }

        [DataMember]
        public string settingFormTitle { set; get;}

        [DataMember]
        public string installSettingTabTitle { set; get; }

        [DataMember]
        public string afterInstallSuccessClose { set; get; }

        [DataMember]
        public string installMethod { set; get; }

        [DataMember]
        public string overlayInstall { set; get; }

        [DataMember]
        public string downgradeOverlayInsall { set; get; }

        [DataMember]
        public string settingFormBottomTip { set; get; }

        /*********************[以下是权限列表翻译]  START***********************/
        [DataMember]
        public string LANG_ACCESS_COARSE_LOCATION { set; get; }
        [DataMember]
        public string LANG_ACCESS_FINE_LOCATION { set; get; }
        [DataMember]
        public string LANG_ACCESS_LOCATION_EXTRA_COMMANDS { set; get; }
        [DataMember]
        public string LANG_ACCESS_MOCK_LOCATION { set; get; }
        [DataMember]
        public string LANG_ACCESS_NETWORK_STATE { set; get; }
        [DataMember]
        public string LANG_ACCESS_SURFACE_FLINGER { set; get; }
        [DataMember]
        public string LANG_ACCESS_WIFI_STATE { set; get; }
        [DataMember]
        public string LANG_BATTERY_STATS { set; get; }
        [DataMember]
        public string LANG_BLUETOOTH { set; get; }
        [DataMember]
        public string LANG_BLUETOOTH_ADMIN { set; get; }
        [DataMember]
        public string LANG_BRICK { set; get; }
        [DataMember]
        public string LANG_BROADCAST_PACKAGE_REMOVED { set; get; }
        [DataMember]
        public string LANG_BROADCAST_SMS { set; get; }
        [DataMember]
        public string LANG_BROADCAST_STICKY { set; get; }
        [DataMember]
        public string LANG_BROADCAST_WAP_PUSH { set; get; }
        [DataMember]
        public string LANG_CALL_PHONE { set; get; }
        [DataMember]
        public string LANG_CALL_PRIVILEGED { set; get; }
        [DataMember]
        public string LANG_CAMERA { set; get; }
        [DataMember]
        public string LANG_CHANGE_CONFIGURATION { set; get; }
        [DataMember]
        public string LANG_CHANGE_NETWORK_STATE { set; get; }
        [DataMember]
        public string LANG_CHANGE_WIFI_MULTICAST_STATE { set; get; }
        [DataMember]
        public string LANG_CHANGE_WIFI_STATE { set; get; }
        [DataMember]
        public string LANG_CLEAR_APP_CACHE { set; get; }
        [DataMember]
        public string LANG_CLEAR_APP_USER_DATA { set; get; }
        [DataMember]
        public string LANG_CONTROL_LOCATION_UPDATES { set; get; }
        [DataMember]
        public string LANG_DELETE_CACHE_FILES { set; get; }
        [DataMember]
        public string LANG_DELETE_PACKAGES { set; get; }
        [DataMember]
        public string LANG_DEVICE_POWER { set; get; }
        [DataMember]
        public string LANG_DIAGNOSTIC { set; get; }
        [DataMember]
        public string LANG_DISABLE_KEYGUARD { set; get; }
        [DataMember]
        public string LANG_DUMP { set; get; }
        [DataMember]
        public string LANG_EXPAND_STATUS_BAR { set; get; }
        [DataMember]
        public string LANG_FACTORY_TEST { set; get; }
        [DataMember]
        public string LANG_FLASHLIGHT { set; get; }
        [DataMember]
        public string LANG_FORCE_BACK { set; get; }
        [DataMember]
        public string LANG_GET_PACKAGE_SIZE { set; get; }
        [DataMember]
        public string LANG_GET_TASKS { set; get; }
        [DataMember]
        public string LANG_GLOBAL_SEARCH { set; get; }
        [DataMember]
        public string LANG_HARDWARE_TEST { set; get; }
        [DataMember]
        public string LANG_INJECT_EVENTS { set; get; }
        [DataMember]
        public string LANG_INSTALL_LOCATION_PROVIDER { set; get; }
        [DataMember]
        public string LANG_INSTALL_PACKAGES { set; get; }
        [DataMember]
        public string LANG_INTERNAL_SYSTEM_WINDOW { set; get; }
        [DataMember]
        public string LANG_INTERNET { set; get; }
        [DataMember]
        public string LANG_KILL_BACKGROUND_PROCESSES { set; get; }
        [DataMember]
        public string LANG_MANAGE_ACCOUNTS { set; get; }
        [DataMember]
        public string LANG_MANAGE_APP_TOKENS { set; get; }
        [DataMember]
        public string LANG_MTWEAK_USER { set; get; }
        [DataMember]
        public string LANG_MTWEAK_FORUM { set; get; }
        [DataMember]
        public string LANG_MASTER_CLEAR { set; get; }
        [DataMember]
        public string LANG_MODIFY_AUDIO_SETTINGS { set; get; }
        [DataMember]
        public string LANG_MODIFY_PHONE_STATE { set; get; }
        [DataMember]
        public string LANG_MOUNT_FORMAT_FILESYSTEMS { set; get; }
        [DataMember]
        public string LANG_MOUNT_UNMOUNT_FILESYSTEMS { set; get; }
        [DataMember]
        public string LANG_NFC { set; get; }
        [DataMember]
        public string LANG_PERSISTENT_ACTIVITY { set; get; }
        [DataMember]
        public string LANG_PROCESS_OUTGOING_CALLS { set; get; }
        [DataMember]
        public string LANG_READ_CALENDAR { set; get; }
        [DataMember]
        public string LANG_READ_CONTACTS { set; get; }
        [DataMember]
        public string LANG_READ_FRAME_BUFFER { set; get; }
        [DataMember]
        public string LANG_READ_HISTORY_BOOKMARKS { set; get; }
        [DataMember]
        public string LANG_READ_INPUT_STATE { set; get; }
        [DataMember]
        public string LANG_READ_LOGS { set; get; }
        [DataMember]
        public string LANG_READ_PHONE_STATE { set; get; }
        [DataMember]
        public string LANG_READ_SMS { set; get; }
        [DataMember]
        public string LANG_READ_EXTERNAL_STORAGE { set; get; }
        [DataMember]
        public string LANG_READ_SYNC_SETTINGS { set; get; }
        [DataMember]
        public string LANG_READ_SYNC_STATS { set; get; }
        [DataMember]
        public string LANG_REBOOT { set; get; }
        [DataMember]
        public string LANG_RECEIVE_BOOT_COMPLETED { set; get; }
        [DataMember]
        public string LANG_RECEIVE_MMS { set; get; }
        [DataMember]
        public string LANG_RECEIVE_SMS { set; get; }
        [DataMember]
        public string LANG_RECEIVE_WAP_PUSH { set; get; }
        [DataMember]
        public string LANG_RECORD_AUDIO { set; get; }
        [DataMember]
        public string LANG_REORDER_TASKS { set; get; }
        [DataMember]
        public string LANG_RESTART_PACKAGES { set; get; }
        [DataMember]
        public string LANG_SEND_SMS { set; get; }
        [DataMember]
        public string LANG_SET_ACTIVITY_WATCHER { set; get; }
        [DataMember]
        public string LANG_SET_ALARM { set; get; }
        [DataMember]
        public string LANG_SET_ALWAYS_FINISH { set; get; }
        [DataMember]
        public string LANG_SET_ANIMATION_SCALE { set; get; }
        [DataMember]
        public string LANG_SET_DEBUG_APP { set; get; }
        [DataMember]
        public string LANG_SET_ORIENTATION { set; get; }
        [DataMember]
        public string LANG_SET_PREFERRED_APPLICATIONS { set; get; }
        [DataMember]
        public string LANG_SET_PROCESS_LIMIT { set; get; }
        [DataMember]
        public string LANG_SET_TIME { set; get; }
        [DataMember]
        public string LANG_SET_TIME_ZONE { set; get; }
        [DataMember]
        public string LANG_SET_WALLPAPER { set; get; }
        [DataMember]
        public string LANG_SET_WALLPAPER_HINTS { set; get; }
        [DataMember]
        public string LANG_SIGNAL_PERSISTENT_PROCESSES { set; get; }
        [DataMember]
        public string LANG_STATUS_BAR { set; get; }
        [DataMember]
        public string LANG_SUBSCRIBED_FEEDS_READ { set; get; }
        [DataMember]
        public string LANG_SUBSCRIBED_FEEDS_WRITE { set; get; }
        [DataMember]
        public string LANG_SYSTEM_ALERT_WINDOW { set; get; }
        [DataMember]
        public string LANG_UPDATE_DEVICE_STATS { set; get; }
        [DataMember]
        public string LANG_USE_CREDENTIALS { set; get; }
        [DataMember]
        public string LANG_USE_SIP { set; get; }
        [DataMember]
        public string LANG_VIBRATE { set; get; }
        [DataMember]
        public string LANG_WAKE_LOCK { set; get; }
        [DataMember]
        public string LANG_WRITE_APN_SETTINGS { set; get; }
        [DataMember]
        public string LANG_WRITE_CALENDAR { set; get; }
        [DataMember]
        public string LANG_WRITE_CONTACTS { set; get; }
        [DataMember]
        public string LANG_WRITE_EXTERNAL_STORAGE { set; get; }
        [DataMember]
        public string LANG_WRITE_GSERVICES { set; get; }
        [DataMember]
        public string LANG_WRITE_HISTORY_BOOKMARKS { set; get; }
        [DataMember]
        public string LANG_WRITE_SECURE_SETTINGS { set; get; }
        [DataMember]
        public string LANG_WRITE_SETTINGS { set; get; }
        [DataMember]
        public string LANG_WRITE_SMS { set; get; }
        [DataMember]
        public string LANG_WRITE_SYNC_SETTINGS { set; get; }




        /*********************[以上是权限列表翻译]  E N D***********************/
   
    }
}
