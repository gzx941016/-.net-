using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 重写tostring__方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Console.WriteLine(p.ToString());
            Console.ReadKey();
        }
    }
    public class Person
    {
        public override string ToString()  //父类是Object，里面有tostring方法，在子类中重写  不重写默认输出所在的命名空间和类名
        {
            return "Hello World";
        }
    }
}
