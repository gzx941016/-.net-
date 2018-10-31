using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MD5加密
{
    class Program
    {
        static void Main(string[] args)
        {
            //123  的MD5值：202cb962ac59075b964b07152d234b70   202cb962ac5975b964b7152d234b70
            string s = GetMD5("123");
            Console.WriteLine(s);
            Console.ReadKey();
        }
        public static string GetMD5(string STR)
        {

            byte[] buffer = Encoding.Default.GetBytes(STR);
            MD5 md5 = MD5.Create();
            buffer= md5.ComputeHash(buffer);
            //出现了乱码（不是编码格式的原因）
            /*、
             字节数组转化为字符串
             1、将字节数组中的元素按照指定的格式转化为字符串
             2、直接将字节数组ToString()
             3、将字节数组 中的每个元素ToString()*/
            // STR = Encoding.Default.GetString(buffer);  此种方法不可用
            string NewStr = "";
            for (int i = 0; i < buffer.Length; i++)
            {
                NewStr += buffer[i].ToString("x2");  //会得到一个10进制，而这里需要一个十六进制，需要在ToString()括号中加x，代表把这个字符串转化为十六进制
                //x2代表：举例2018年10月30日，如果是单数日的话需要前面加0，例如2018年10月09日，要不无法对齐
            }
            return NewStr;
        }
    }
}
