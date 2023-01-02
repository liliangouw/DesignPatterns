using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObServer
{
    delegate void EventHandler();
    internal class ConcreteSubject : Subject
    {
        public event EventHandler Update;
        public string SubjectState { get ; set; }

        public void Notify()
        {
            Update();
        }
    }
}
