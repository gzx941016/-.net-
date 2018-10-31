using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 访问修饰符
{
    class Program
    {
        static void Main(string[] args)
        {

            //  C#中的所有的访问修饰符及访问权限
            //protected  受保护的，只能在当前类及其子类中访问
            //public  公共的公开的
            //private 私有的，只能在当前的类中访问
            //internal 只能在当前项目中访问 在同一个项目当中，public和internal的权限是一样的
            //protected internal  两个权限的加总

            //1、能都修饰类的访问修饰符只有两个：punlic和internal
            //2、可访问性不一致
            //子类的访问权限不能高于父类的访问权限
        }

    }
}
