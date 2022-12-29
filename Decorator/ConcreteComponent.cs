using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ConcreteComponent : Component
    {
        public override void Opeation()
        {
            Console.WriteLine("具体类的动作");
        }
    }
}
