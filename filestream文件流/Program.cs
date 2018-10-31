using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filestream文件流
{
    class Program
    {
        static void Main(string[] args)
        {


            //创建文件流对象。参数为文件路径，操作文件的方式【枚举：添加、创建、打开、新打开、】，文件作用：读、写、读和写
            //  FileStream fileStream = new FileStream(@"C:\Users\Administrator\Desktop\大猪.txt",FileMode.OpenOrCreate,FileAccess.Read);
            //  //用来接收读到的文件流字节
            //  byte[] buffer= new byte[1024 * 1024 * 5];
            //  //返回本次实际读取到的有效字节数 读取到的为字节数组，读取的偏移量，读取的长度
            //  int r = fileStream.Read(buffer, 0, buffer.Length);
            //  //将字节数组中的每一个元素按照指定的编码格式解码成字符串
            //string s=  Encoding.Default.GetString(buffer,0,r); //参数：要解码的字节数组，解码开始的位置index,需要解码的字节数
            ////自动清理机制不会清理文件流，所以需要手动关闭并且释放资源
            //  fileStream.Close();
            //  fileStream.Dispose();
            //  Console.WriteLine(s);


            //fileStream写入数据

            using (FileStream fsWrite=new FileStream(@"C:\Users\Administrator\Desktop\大猪.txt",FileMode.OpenOrCreate,FileAccess.Write))
            {
                string str = "看我有没有把你覆盖掉";
                byte[] buffer = Encoding.Default.GetBytes(str);
                fsWrite.Write(buffer, 0, buffer.Length);
            }
            Console.WriteLine("写入成功");


        }
    }
}
