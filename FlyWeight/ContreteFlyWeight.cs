using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    public class ContreteFlyWeight : FlyWeight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("具体的FlyWeight:"+extrinsicstate.ToString());
        }
    }
}
