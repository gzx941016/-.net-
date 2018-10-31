using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 显示实现接口
{
    class Program
    {
        static void Main(string[] args)
        {

            //显示实现接口就是为了解决方法的重名的问题

            //继承接口的类里有接口相同的方法，默认会是接口的，要让两个方法同时实现，接口的方法需要  接口名.方法名()

        }
    }
    public class Bird:IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("鸟会飞");
        }

         void IFlyable.Fly()
        {
            Console.WriteLine("我是接口的鸟在飞");
        }
    }
    public interface IFlyable
    {
        void Fly();
    }
}
