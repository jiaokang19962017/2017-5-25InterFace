using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// 动物类
    /// </summary>
    abstract class Animal
    {
        /// <summary>
        /// 动物的类别
        /// </summary>
        protected string TypeName;
        /// <summary>
        /// 动物叫方法
        /// </summary>
        public void Cal()
        {
            Console.WriteLine("嗷嗷叫");
        }
        /// <summary>
        /// 睡觉方法
        /// </summary>
        public void Sleep()
        {
            Console.WriteLine("呼呼睡");
        }
        public Animal()
        {

        }

        public Animal(string typeName)
        {
            this.TypeName = TypeName;
        }
        /// <summary>
        /// 抽象吃饭方法
        /// </summary>
        public abstract void Eat();
    }
}
