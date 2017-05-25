using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// 交通工具类:基类
    /// </summary>
    class Vehicle
    {
        private int Num;
        /// <summary>
        /// 类别
        /// </summary>
        protected string Type;
        /// <summary>
        /// 重量
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// 载客虚方法
        /// </summary>
        public virtual void Passenger()
        {
            Console.WriteLine("载客");
        }
        public Vehicle()
        {

        }
        public Vehicle(string typeName)
        {
            this.Type = typeName;
        }
    
    }
}
