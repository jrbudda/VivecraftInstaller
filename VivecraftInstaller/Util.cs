using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace VivecraftInstaller
{
    class Util
    {
        public static bool checkMD5(FileInfo a, String b)
        {
            if (a.Exists == false) return false;
            if (b == null) return true;
            return GetMd5(a).ToLower().Equals(b.ToLower());
        }

        public static string GetMd5(FileInfo fo)
        {
            if (!fo.Exists)
                return null;

            if (fo.Length < 1)
                return null;

            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(fo.FullName))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "").ToLower();
                }
            }
        }

        public static string getWebRequestwithTimeout(string address, short timeoutS)
        {
            var w = new myWebClient();
            w.Timeout = timeoutS;
            w.Encoding = Encoding.UTF8;
            {
                try
                {
                    var ret = w.DownloadString(address);
                    return ret;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public static byte[] getWebBinarywithTimeout(string address, short timeoutS)
        {
            var w = new myWebClient();
            w.Timeout = timeoutS;
            {
                try
                {
                    var ret = w.DownloadData(address);
                    return ret;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
