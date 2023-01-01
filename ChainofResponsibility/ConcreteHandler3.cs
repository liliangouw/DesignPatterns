using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    internal class ConcreteHandler3:Handler
    {
        public override void HandleRequest(int request)
        {
            //在请求数在20-30之间有权处理
            if (request >= 20 && request < 30)
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
