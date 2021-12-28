using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace WSAInstallTool.Util
{
    class CommonUtil
    {
        /// <summary>
        /// Json字符串转内存对象
        /// </summary>
        /// <param name="jsonString"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T JsonToObject<T>(string jsonString)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
            MemoryStream mStream = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
            return (T) serializer.ReadObject(mStream);
        }

        /// <summary>
        /// 获取exe启动的目录
        /// </summary>
        /// <returns>D:\test</returns>
        public static string GetCurrentStartupPath()
        {
            return System.Windows.Forms.Application.StartupPath;
        }
    }
}
