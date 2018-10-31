using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态的最后一个类型接口
{
    class Program
    {
        static void Main(string[] args)
        {

            //接口简介：就是一个规范、能力，
            //接口的语法
            //[pubilc] interface  I....able
            //{
            //  成员；
            // }

            /*
             语法特征：
             接口中的成员不允许添加访问修饰符 默认就是Pubilc
             接口中不允许写具有方法体的函数，也不能字段 
             但是可以有属性，不申明字段的属性，自动属性  
             还可以有索引器*（没学）
             接口与接口之间可以继承，而且可以多继承
             接口不能继承类，类可以继承接口，而且也可以继承类
             只要接口被继承，就必须实现接口中所有的成员
             一个类可以同时继承一个类和实现多个接口，二者都有的时候，继承类必须在实现接口之前
             */
            //声明接口的关键字 interface
        }
    }
    public class Person
    {
        public void CLASS()
        {
            Console.WriteLine("我是人类，可以吃喝拉撒睡");
        }
    }
    public class NBAPlayer
    {
        public void Koulan()
        {
            Console.WriteLine("我可以扣篮");
        }
    }
    public class Student : Person,IEKouLanable
    {
        public string Name
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

      

        public void Koulan()
        {
            Console.WriteLine("我也可以扣篮");
        }
    }

    public interface IEKouLanable
    {
        void Koulan();

        string Name
        {
            get;
            set;
        }
        
    }
}
