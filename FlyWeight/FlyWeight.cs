using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    public abstract class FlyWeight
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extrinsicstate">外部状态码</param>
        public abstract void Operation(int extrinsicstate);
    }
}
