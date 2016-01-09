using System;
using System.IO;

namespace Hash
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            HashService service = new HashService();

            Console.WriteLine("----------------------------------------------");

            if (args.Length < 1)
            {
                Console.WriteLine("错误:请指定文件名。");
            }
            else if (!File.Exists(args[0]))
            {
                Console.WriteLine("错误:指定的文件不存在。");
            }
            else
            {
                Console.WriteLine("文件:{0}", args[0]);
                Console.WriteLine(" MD5:{0}", service.GetFileMd5(args[0]));
                Console.WriteLine("SHA1:{0}", service.GetFileSha1(args[0]));
            }
            
            Console.WriteLine("----------------------------------------------");
        }
    }
}