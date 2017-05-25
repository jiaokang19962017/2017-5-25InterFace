using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Bird : Animal,Ifly
    {
        /// <summary>
        /// 鸟的名字
        /// </summary>
        public string BirdName { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// 颜色
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// 覆盖父类的抽象吃饭方法
        /// </summary>
        public override void Eat()
        {
            
            Console.WriteLine("鸟吃饭");
        }
        /// <summary>
        /// 鸟唱歌方法
        /// </summary>
        public void Sing()
        {
            Console.WriteLine("鸟唱歌");
        }
        public Bird()
        {

        }
        public Bird(string TypeName,string Color):base(TypeName)
        {
            this.Color = Color;
        }
        public string GetTypeName() {
            return base.TypeName;
        }

        void Ifly.TakeOff()
        {
            Console.WriteLine("鸟起飞");
        }

        void Ifly.Fly()
        {
            Console.WriteLine("鸟飞翔");
        }

        void Ifly.Land()
        {
            Console.WriteLine("鸟降落");
        }
    }
}
