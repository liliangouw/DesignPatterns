using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class RefinedAbstration:Abstraction
    {
        public override void Operation()
        {
            implementor.OperationImp();
        }
    }
}
