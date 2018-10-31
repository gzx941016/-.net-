using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 合作写一个模块代码_部分类
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    //部分类：两个类都是属于类的一部分 在类前面加关键字 partial  ，在一个类中写的成员在另一个里面全部都可以用，不论是共有的还是私有的
    public partial class Person
    {
        private string name;
    }
    public partial class Person
    {
        public void test()
        {
            name = "张三";
        }
    }
}
