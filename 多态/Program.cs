using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态
{
    class Program
    {
        static void Main(string[] args)
        {

            //多态概念：让一个对象表现出多种状态（类型）

            //实现多态主要有三种手段：1、虚方法 2、抽象类 3、接口

            //虚方法：首先将父类的方法标记为虚方法，使用关键字  virtual 。效果就是这个函数可以被子类重新写一遍(可以提取出父类的前提下)


            //当父类方法不知道如何去实现的时候，可以考虑将父类写成抽象类，将方法写成抽象方法
            //抽象类：抽象类的关键字  abstract  方法也一样.  抽象方法是不允许有方法体
            
            Chinese chin = new Chinese("我媳妇");
            Chinese chin1 = new Chinese("她老头");
            Japanese j1 = new Japanese("树下君");
            Japanese j2 = new Japanese("井边子");
            Korea k1 = new Korea("金秀贤");
            Korea k2 = new Korea("金贤秀");
            American a1 = new American("科比布莱恩特");
            American a2 = new American("奥沙利文");
            Person[] pers = new Person[] { chin, chin1,j1,j2,k1,k2,a1,a2 };
            for (int i = 0; i < pers.Length; i++)
            {
                //if(pers[i] is Chinese)
                //{
                //    ((Chinese)pers[i]).SayHello();
                //}else if(pers[i] is Japanese)
                //{
                //    ((Japanese)pers[i]).SayHello();
                //}else if(pers[i] is Korea)
                //{
                //    ((Korea)pers[i]).SayHello();
                //}
                //else
                //{
                //    ((American)pers[i]).SayHello();
                //}
                pers[i].SayHello();
            }
        }
    }
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

        public Person(string name)
        {
            this.Name = name;
        }
        public virtual void SayHello()
        {
            Console.WriteLine("我是人类");
        }
    }
    public class Chinese : Person
    {
        public Chinese(string name) : base(name)
        {

        }
        public override void SayHello()
        {
            Console.WriteLine("我是中国人，我叫{0}",this.Name) ;
        }
    }
    public class Japanese:Person
    {
        public Japanese(string name) : base(name)
        {

        }
        public override void SayHello()
        {
            Console.WriteLine("我是脚盆国人，我叫{0}",this.Name);
        }
    }
    public class Korea : Person
    {
        public Korea(string name) : base(name)
        {

        }
        public override void SayHello()
        {
            Console.WriteLine("我是棒之思密达,我叫{0}",this.Name);
        }
    }
    public class American : Person
    {
        public American(string name) : base(name)
        {

        }
        public override void SayHello()
        {
            Console.WriteLine("我是米国人，我叫{0}",this.Name);
        }
    }
}
