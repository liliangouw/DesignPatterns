using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class ConcreteImplentorA : Implementor
    {
        public override void OperationImp()
        {
            Console.WriteLine("实现A");
        }
    }
}
