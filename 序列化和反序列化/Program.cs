using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace 序列化和反序列化
{
    class Program
    {
        static void Main(string[] args)
        {

            //序列化就是将对象转换为二进制
            //反序列化就是将二进制转换为对象
            //作用:传输数据
            //将p这个对象，传输到对方电脑
            //Person p = new Person();
            //p.Name = "张三";
            //p.Age = 19;
            //p.Gender = '男';
            //using (FileStream fs=new FileStream(@"C:\Users\Administrator\Desktop\序列化和反序列化.txt", FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    //开始序列化对象
            //    BinaryFormatter bf = new BinaryFormatter();
            //    bf.Serialize(fs, p);
            //}
            //Console.WriteLine("序列化成功");
            //Console.ReadKey();
            //需要把这个类标记为可以被序列化的  类前边[Serializable]



            //反序列化：就是将对方发送过来的二进制，反序列化成对象
            //使用流读取文件
            Person pp ;
            using (FileStream fsRead=new FileStream(@"C:\Users\Administrator\Desktop\序列化和反序列化.txt", FileMode.Open, FileAccess.Read))
            {
                //开始序列化对象
                BinaryFormatter bf = new BinaryFormatter();
               
               pp=(Person)bf.Deserialize(fsRead);

               
            }

            Console.WriteLine(pp.Name);
            Console.WriteLine(pp.Age);
            Console.WriteLine(pp.Gender);

            Console.ReadKey();


        }
    }
    [Serializable]
    public class Person
    {
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }



        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                _age = value;
            }
        }

      

        private char gender;
        public char Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }
    }
}
