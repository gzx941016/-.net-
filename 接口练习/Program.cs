using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口练习
{
    class Program
    {
        static void Main(string[] args)
        {

            //麻雀会飞，鹦鹉会飞，鸵鸟不会飞，企鹅不会飞，直升机会飞
            //用多态实现
            //需要虚方法，抽象类，接口

            IFlyable fly = new Plane(); // new yingwu();// new maque();
            fly.Fly();
            Console.ReadKey();
        }
    }
    public  class Bird
    {
        public double Wings
        {
            get;
            set;
        }
        public void EatAndDrink()
        {
            Console.WriteLine("我会吃喝");
        }
    }

    public interface IFlyable
    {
        void Fly();
       
    }
    public interface ISpeakable
    {
        void Speak();
    }

    public class maque : Bird, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("麻雀会飞");
        }

        
    }
    public class yingwu : Bird, IFlyable, ISpeakable
    {
        public void Fly()
        {
            Console.WriteLine("鹦鹉会飞");
        }

        public void Speak()
        {
            Console.WriteLine("鹦鹉会说话");
        }
    }
    public class tuoniao : Bird
    {

    }
    public class QQ : Bird
    {
        
    }
    public class Plane : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("飞机会飞");
        }
    }

}
