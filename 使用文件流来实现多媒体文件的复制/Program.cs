using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 使用文件流来实现多媒体文件的复制
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = @"C:\Users\Administrator\Desktop\英雄泪(国语)-王杰-86762.flac";
            string target = @"C:\Users\Administrator\Desktop\英雄泪(国语)-王杰-复制.flac";
            //思路：先将要复制的多媒体文件读取出来，然后再将文件写入到指定的路径下

            CopyFile(source, target);
            Console.WriteLine(  "复制成功");


        }

        public static void CopyFile(string source,string target)
        {
            using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
            {

               
               
                using (FileStream fsWrite=new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    while (true)
                    {
                        int r = fsRead.Read(buffer, 0, buffer.Length);
                        string s = Encoding.Default.GetString(buffer);

                        if (r == 0)
                        {
                            break;
                        }

                        fsWrite.Write(buffer, 0,r);
                    }
                   

                }
            }

        }
    }
}
