using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feil类
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //Create Delete copy move
            // File.Create(@"C:\Users\Administrator\Desktop\小猪.txt");
            // Console.WriteLine("创建成功");
            // Console.ReadKey();
            // //写
            // string contents = "今天天气好晴朗处处好风光";
            // byte[] Buffer = Encoding.Default.GetBytes(contents);
            // File.WriteAllBytes(@"C:\Users\Administrator\Desktop\大猪.txt", Buffer);
            // //读

            //byte[] buf= File.ReadAllBytes(@"C:\Users\Administrator\Desktop\大猪.txt");
            // string str = Encoding.Default.GetString(buf);
            // Console.WriteLine(str);


            //题目：把一个数组中奇数偶数分别放到两个集合中，把两个集合合并为一个集合，要求奇数显示在左，偶数显示在右
            //int[] test = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //List<int> odd_num = new List<int>();
            //List<int> even_num = new List<int>();
            //for (int i = 0; i < test.Length; i++)
            //{
            //    if (test[i] % 2 == 0)
            //    {
            //       even_num.Add(test[i]);
            //        Console.WriteLine("偶数："+test[i]);
            //    }
            //    else
            //    {
            //        odd_num.Add(test[i]);
            //        Console.WriteLine("奇数："+test[i]);
            //    }
            //}


            //List<int> alllist = new List<int>();
            //alllist.InsertRange(0, odd_num);
            //alllist.InsertRange(odd_num.Count, even_num);


            //foreach (var item in alllist)
            //{
            //    Console.WriteLine(item);
            //}



            //题目：查询“Welcome to China”中字符出现的次数，不区分大小写
            //string str = "Welcome to China";
            //str = str.ToLower();
            //Dictionary<char, int> readdic = new Dictionary<char, int>();
           
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i] ==  ' ')
            //    {
            //        continue;
            //    }
                
            //    if (readdic.ContainsKey(str[i]))
            //    {
            //        readdic[str[i]]++;
            //    }
            //    else
            //    {
            //        readdic[str[i]] = 1;
            //    }
            //}

            //foreach (KeyValuePair<char,int> item in readdic)
            //{
            //    Console.WriteLine("字母{0}出现了{1}次",item.Key,item.Value);
            //}
        }
    }
}
