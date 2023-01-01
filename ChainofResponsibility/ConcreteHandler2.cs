using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    internal class ConcreteHandler2:Handler
    {
        public override void HandleRequest(int request)
        {
            //在请求数在10-20之间有权处理
            if (request >= 10 && request < 20)
            {
                Console.WriteLine($"{this.GetType().Name}处理请求{request.ToString()}");
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }
}
