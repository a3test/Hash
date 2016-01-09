using System.IO;
using System.Security.Cryptography;

namespace Hash
{
    public class HashService
    {
        /// <summary>
        /// 获取文件 MD5 值
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public string GetFileMd5(string filePath)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            FileStream fs = new FileStream(filePath, FileMode.Open);
            byte[] hash = md5.ComputeHash(fs);
            fs.Close();

            string ret = "";
            foreach (byte b in hash)
            {
                ret += b.ToString("X2");
            }
            return ret;
        }

        public string GetFileSha1(string filePath)
        {
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            FileStream fs = new FileStream(filePath, FileMode.Open);
            byte[] hash = sha1.ComputeHash(fs);
            fs.Close();

            string ret = "";
            foreach (byte b in hash)
            {
                ret += b.ToString("X2");
            }
            return ret;
        }
    }
}