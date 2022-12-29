using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ConcreteDecoratorA:Decorator
    {
        public override void Opeation()
        {
            Console.WriteLine("装饰A的动作");
            base.Opeation();
        }
    }
}
