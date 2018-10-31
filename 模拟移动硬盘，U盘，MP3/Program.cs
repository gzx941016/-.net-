using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模拟移动硬盘_U盘_MP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //用多态来实现将移动硬盘或者U盘mp3插到电脑上进行读写数据
            MobileStorage ms = new MobileDisk(); //new Udisk  new MP3
            Computer cpu = new Computer
            {
                Ms = ms
            };
            cpu.CPU_Read();
            cpu.CPU_Write();

            Console.ReadKey();

        }
    }

    public abstract class MobileStorage
    {

        public abstract void Read();
        public abstract void Write();
    }
    public class MobileDisk : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("移动硬盘在读取数据");
        }

        public override void Write()
        {
            Console.WriteLine("移动硬盘在写入数据");
        }
    }
    public class UDisk : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("U盘在读取数据");
        }

        public override void Write()
        {
            Console.WriteLine("U盘在写入数据");
        }
    }
    public class MP3 : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("MP3在读取数据");
        }

        public override void Write()
        {
            Console.WriteLine("MP3在写入数据");
        }

        public void Play()
        {
            Console.WriteLine("MP3自己可以播放音乐");
        }
    }



    public class Computer
    {

        private MobileStorage ms;


        public MobileStorage Ms
        {
            get
            {
                return ms;
            }

            set
            {
                ms = value;
            }
        }

        public void CPU_Read()
        {
            Ms.Read();
        }
        public  void CPU_Write()
        {
            Ms.Write();
        }
    }
}
