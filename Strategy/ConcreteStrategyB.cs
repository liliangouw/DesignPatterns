using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class ConcreteStrategyB:Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("实现算法B");
        }
    }
}
