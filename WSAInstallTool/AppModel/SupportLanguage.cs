using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WSAInstallTool.AppModel
{
    /// <summary>
    /// 支持的语言
    /// </summary>
    [DataContractAttribute]
    class SupportLanguage
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string file { get; set; }

        public override string ToString()
        {
            return "id = " + id + ", name = " + name + ", file = " + file;
        }
    }
}
