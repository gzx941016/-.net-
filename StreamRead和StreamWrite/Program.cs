using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamRead和StreamWrite
{
    class Program
    {
        static void Main(string[] args)
        {

            // 读写入文本文件可以用StreamWriter和StreamReader
            //using (StreamReader s=new StreamReader(@"C:\Users\Administrator\Desktop\大猪.txt",Encoding.Default))
            //{
            //    while (!s.EndOfStream)  //读到结尾
            //    {
            //        Console.WriteLine(s.ReadLine());
            //    }

            //}   

            //写入文本文件
            using (StreamWriter w = new StreamWriter(@"C:\Users\Administrator\Desktop\大猪2.txt",true))
            {
                w.Write("说错了，是好看不？她就在旁边，你想好了再说");
            }
           

        }
    }
}
