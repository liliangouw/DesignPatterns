using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ConcreteDecoratorB:Decorator
    {
        public override void Opeation()
        {
            Console.WriteLine("装饰B的操作");
            base.Opeation();
        }
    }
}
