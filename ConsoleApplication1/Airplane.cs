using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// 飞机类
    /// </summary>
    class Airplane : Vehicle,Ifly
    {
        /// <summary>
        /// 飞机的名字
        /// </summary>
        private string name;
        /// <summary>
        /// 颜色
        /// </summary>
        private string color;

        private double Speed { get; set; }

        public Airplane()
        {

        }
        /// <summary>
        /// 飞机的构造函数(初始化飞机的颜色,速度,名称)
        /// </summary>
        /// <param name="typeName">类别名称</param>
        /// <param name="name">飞机名</param>
        /// <param name="color">颜色</param>
        /// <param name="speed">速度</param>
        public Airplane(string typeName,string name,string color,double speed):base(typeName)
        {
            this.color = color;
            this.name = name;
            this.Speed = speed;
        }
        /// <summary>
        /// 重写了父类的虚方法
        /// </summary>
        public override void Passenger()
        {
            Console.WriteLine("济宁号飞机正在载客32人");
        }

        /// <summary>
        /// 飞机的空中加油方法
        /// </summary>
        public void PlusOil()
        {
            Console.WriteLine("空中加油");
        }
        /// <summary>
        /// 输出飞机信息方法
        /// </summary>
        public void PrintInfo()
        {
            Console.WriteLine("交通工具类别:"+this.Type+"飞机名称:"+name+"颜色"+color+"速度"+Speed);
        }

        public void TakeOff()
        {
            Console.WriteLine("飞机起飞");
        }

        public void Fly()
        {
            Console.WriteLine("飞机翱翔");
        }

        public void Land()
        {
            Console.WriteLine("飞机降落");
        }
    }
}
