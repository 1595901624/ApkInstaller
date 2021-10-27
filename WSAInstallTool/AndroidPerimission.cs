using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSAInstallTool
{
    class AndroidPerimission
    {
        public static readonly AndroidPerimission READ_EXTERNAL_STORAGE = new AndroidPerimission("android.permission.READ_EXTERNAL_STORAGE", "允许程序读取内部存储");
        public static readonly AndroidPerimission WRITE_EXTERNAL_STORAGE = new AndroidPerimission("android.permission.WRITE_EXTERNAL_STORAGE", "允许程序写入外部存储");
        public static readonly AndroidPerimission ACCESS_COARSE_LOCATION = new AndroidPerimission("android.permission.ACCESS_COARSE_LOCATION", "通过WiFi或移动基站的方式获取用户粗略的经纬度信息，定位精度大概误差在30~1500米");
        public static readonly AndroidPerimission ACCESS_FINE_LOCATION = new AndroidPerimission("android.permission.ACCESS_FINE_LOCATION", "通过GPS芯片接收卫星的定位信息，定位精度达10米以内");
        public static readonly AndroidPerimission ACCESS_LOCATION_EXTRA_COMMANDS = new AndroidPerimission("android.permission.ACCESS_LOCATION_EXTRA_COMMANDS", "允许程序访问额外的定位提供者指令");
        public static readonly AndroidPerimission ACCESS_MOCK_LOCATION = new AndroidPerimission("android.permission.ACCESS_MOCK_LOCATION", "获取模拟定位信息，一般用于帮助开发者调试应用");
        public static readonly AndroidPerimission ACCESS_NETWORK_STATE = new AndroidPerimission("android.permission.ACCESS_NETWORK_STATE", "获取网络信息状态，如当前的网络连接是否有效");
        public static readonly AndroidPerimission ACCESS_SURFACE_FLINGER = new AndroidPerimission("android.permission.ACCESS_SURFACE_FLINGER", "Android平台上底层的图形显示支持，一般用于游戏或照相机预览界面和底层模式的屏幕截图");
        public static readonly AndroidPerimission ACCESS_WIFI_STATE = new AndroidPerimission("android.permission.ACCESS_WIFI_STATE", "获取当前WiFi接入的状态以及WLAN热点的信息");
        public static readonly AndroidPerimission BATTERY_STATS = new AndroidPerimission("android.permission.BATTERY_STATS", "获取电池电量统计信息");
        public static readonly AndroidPerimission BLUETOOTH = new AndroidPerimission("android.permission.BLUETOOTH", "允许程序连接配对过的蓝牙设备");
        public static readonly AndroidPerimission BLUETOOTH_ADMIN = new AndroidPerimission("android.permission.BLUETOOTH_ADMIN", "允许程序进行发现和配对新的蓝牙设备");
        public static readonly AndroidPerimission BRICK = new AndroidPerimission("android.permission.BRICK", "【危险权限】能够禁止使用手机");
        public static readonly AndroidPerimission BROADCAST_PACKAGE_REMOVED = new AndroidPerimission("android.permission.BROADCAST_PACKAGE_REMOVED", "当一个应用在删除时触发一个广播");
        public static readonly AndroidPerimission BROADCAST_SMS = new AndroidPerimission("android.permission.BROADCAST_SMS", "当收到短信时触发一个广播");
        public static readonly AndroidPerimission BROADCAST_STICKY = new AndroidPerimission("android.permission.BROADCAST_STICKY", "允许一个程序收到广播后快速收到下一个广播");
        public static readonly AndroidPerimission BROADCAST_WAP_PUSH = new AndroidPerimission("android.permission.BROADCAST_WAP_PUSH", "WAP PUSH服务收到后触发一个广播");
        public static readonly AndroidPerimission CALL_PHONE = new AndroidPerimission("android.permission.CALL_PHONE", "允许程序从非系统拨号器里输入电话号码");
        public static readonly AndroidPerimission CALL_PRIVILEGED = new AndroidPerimission("android.permission.CALL_PRIVILEGED", "允许程序拨打电话，替换系统的拨号器界面");
        public static readonly AndroidPerimission CAMERA = new AndroidPerimission("android.permission.CAMERA", "允许访问摄像头进行拍照");
        public static readonly AndroidPerimission CHANGE_CONFIGURATION = new AndroidPerimission("android.permission.CHANGE_CONFIGURATION", "允许当前应用改变配置，如定位");
        public static readonly AndroidPerimission CHANGE_NETWORK_STATE = new AndroidPerimission("android.permission.CHANGE_NETWORK_STATE", "改变网络状态如是否能联网");
        public static readonly AndroidPerimission CHANGE_WIFI_MULTICAST_STATE = new AndroidPerimission("android.permission.CHANGE_WIFI_MULTICAST_STATE", "改变WiFi多播状态");
        public static readonly AndroidPerimission CHANGE_WIFI_STATE = new AndroidPerimission("android.permission.CHANGE_WIFI_STATE", "改变WiFi状态");
        public static readonly AndroidPerimission CLEAR_APP_CACHE = new AndroidPerimission("android.permission.CLEAR_APP_CACHE", "清除应用缓存");
        public static readonly AndroidPerimission CLEAR_APP_USER_DATA = new AndroidPerimission("android.permission.CLEAR_APP_USER_DATA", "清除应用的用户数据");
        public static readonly AndroidPerimission CONTROL_LOCATION_UPDATES = new AndroidPerimission("android.permission.CONTROL_LOCATION_UPDATES", "允许获得移动网络定位信息改变");



        public String permission { get; private set; }
        public String description { get; private set; }

        public AndroidPerimission(String perimissionName, String description)
        {
            this.permission = perimissionName;
            this.description = description;
        }

        public static IEnumerable<AndroidPerimission> Values 
        {
            get
            {
                yield return READ_EXTERNAL_STORAGE;
                yield return WRITE_EXTERNAL_STORAGE;
                yield return ACCESS_COARSE_LOCATION;
                yield return ACCESS_FINE_LOCATION;
                yield return ACCESS_LOCATION_EXTRA_COMMANDS;
                yield return ACCESS_MOCK_LOCATION;
                yield return ACCESS_NETWORK_STATE;
                yield return ACCESS_SURFACE_FLINGER;
                yield return ACCESS_WIFI_STATE;
                yield return BATTERY_STATS;
                yield return BLUETOOTH;
                yield return BLUETOOTH_ADMIN;
                yield return BRICK;
                yield return BROADCAST_PACKAGE_REMOVED;
                yield return BROADCAST_SMS;
                yield return BROADCAST_STICKY;
                yield return BROADCAST_WAP_PUSH;
                yield return CALL_PHONE;
                yield return CALL_PRIVILEGED;
                yield return CAMERA;
                yield return CHANGE_CONFIGURATION;
                yield return CHANGE_NETWORK_STATE;
                yield return CHANGE_WIFI_MULTICAST_STATE;
                yield return CHANGE_WIFI_STATE;
                yield return CLEAR_APP_CACHE;
                yield return CLEAR_APP_USER_DATA;
                yield return CONTROL_LOCATION_UPDATES;
            }

        }
    }
}
