using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObServer
{
    internal class ConcreteObserver2
    {
        private string name;
        public ConcreteSubject Subject { get; set; }
        public ConcreteObserver2(string name, ConcreteSubject subject)
        {
            this.name = name;
            Subject = subject;
        }

        public void CloseGuPiao()
        {
            Console.WriteLine("{0},{1}关闭股票，开始工作", Subject.SubjectState, name);
        }
    }
}
