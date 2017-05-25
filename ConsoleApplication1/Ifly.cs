using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    interface Ifly
    {
        /// <summary>
        /// 起飞
        /// </summary>
        void TakeOff();
        /// <summary>
        /// 飞翔
        /// </summary>
        void Fly();
        /// <summary>
        /// 着陆
        /// </summary>
        void Land();
    }
}
