using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSAInstallTool.Util
{
    class HashUtil
    {
        public enum Sha26ParseType
        {
            StringType,
            StreamType
        }

        public static string GetSha256Hash(string filePath)
        {
            return GetSha256Hash(filePath, Sha26ParseType.StreamType);
        }

        private static string GetSha256Hash(string str, Sha26ParseType type)
        {
            string result = string.Empty;
            byte[] by = null;
            //求字节流的SHA256
            if (type.Equals(Sha26ParseType.StreamType))
            {
                if (!System.IO.File.Exists(str))
                    return result;

                System.IO.FileStream stream = new System.IO.FileStream(str, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                System.Security.Cryptography.SHA256Managed Sha256 = new System.Security.Cryptography.SHA256Managed();
                by = Sha256.ComputeHash(stream);
                stream.Close();
            }
            //求字符串的SHA256
            else
            {
                byte[] SHA256Data = Encoding.UTF8.GetBytes(str);

                System.Security.Cryptography.SHA256Managed Sha256 = new System.Security.Cryptography.SHA256Managed();
                by = Sha256.ComputeHash(SHA256Data);
            }

            result = BitConverter.ToString(by).Replace("-", "").ToLower(); //64
            //return Convert.ToBase64String(by);                         //44

            return result;
        }
    }

    
}
