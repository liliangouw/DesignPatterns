using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class ConcreteMediator : Mediator
    {
        private ConcreteColleague1 _concreteColleague1;
        private ConcreteColleague2 _concreteColleague2;
        public ConcreteColleague1 ConcreteColleague1
        {
            set { _concreteColleague1 = value; }
        }
        public ConcreteColleague2 ConcreteColleague2
        {
            set { _concreteColleague2 = value;}
        }

        public override void Send(string message,Colleague colleague)
        {
            if (colleague == _concreteColleague1)
            {
                _concreteColleague2.Notify(message);
            }
            else
            {
                _concreteColleague1.Notify(message);
            }
        }
    }
}
