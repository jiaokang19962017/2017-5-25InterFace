using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Airplane ap = new Airplane("飞行工具", "济宁号", "白色", 2000);
            ap.PrintInfo();//输出飞机信息方法
            ap.Passenger();//载客方法
            ap.PlusOil();//空中加油方法




            Bird b = new Bird("鸟类","红色");
            b.BirdName = "黄鹂鸟";
            b.Sex = "女";
            Console.WriteLine(b.GetTypeName()+"名字:"+b.BirdName+"颜色"+b.Color);
        }
    }
}
