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
    }
}
