using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class ConcreteImplentorB : Implementor
    {
        public override void OperationImp()
        {
            Console.WriteLine("实现B");
        }
    }
}
