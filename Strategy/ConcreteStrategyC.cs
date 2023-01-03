using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class ConcreteStrategyC:Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("实现算法C");
        }
    }
}
