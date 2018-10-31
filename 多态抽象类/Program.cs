using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态抽象类
{
    class Program
    {
        static void Main(string[] args)
        {
            //狗狗会叫  猫咪也会叫
            //抽象类不能创建实例
            Animal a = new Cat();
            a.Bark();
        }

    }
    public abstract class Animal
    {
        public abstract void Bark();
        

        
    }

    public  class Dog:Animal
    {
        public override void Bark()
        {
            Console.WriteLine("狗狗旺旺的叫");
        }
    }
    public class Cat : Animal
    {
        public override void Bark()
        {
            Console.WriteLine("猫咪喵喵的叫");
        }
    }
}
