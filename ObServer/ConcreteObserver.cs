using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObServer
{
    internal class ConcreteObserver
    {
        private string name;
        public ConcreteSubject Subject { get; set; }
        public ConcreteObserver(string name, ConcreteSubject subject)
        {
            this.name = name;
            Subject = subject;
        }

        public void CloseNBA()
        {
            Console.WriteLine("{0},{1}关闭直播，开始工作",Subject.SubjectState,name);
        }

    }
}
