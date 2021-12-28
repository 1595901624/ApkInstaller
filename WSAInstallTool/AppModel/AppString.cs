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

    }
}
