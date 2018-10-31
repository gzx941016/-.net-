using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {

            //设计这个项目的一种方式，一共有23种设计模式
            //简单工厂的核心：根据用户的输入创建对象赋值给父类

            Console.WriteLine("请输入想要生产的品牌");
            string brand = Console.ReadLine();
            NoteBook nb = GetNoteBook(brand);
            nb.SayHello();
            Console.ReadKey();
            
        }
        public static NoteBook GetNoteBook(string brand)
        {
            NoteBook nb = null;
            switch (brand)
            {
                case "Dell":
                    nb = new Dell();
                    break;
                case "IBM":
                    nb = new IBM();
                    break;
                case "Lenovo":
                    nb = new Lenovo();
                    break;
            }
            return nb;
        
        }
    }
    public abstract class NoteBook
    {
        public abstract void SayHello();
    }
    public class Dell : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是戴尔");
        }
    }
    public class IBM : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是IBM");
        }
    }
    public class Lenovo : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是联想");
        }
    }
}
