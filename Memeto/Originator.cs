using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memeto
{
    internal class Originator
    {
        public string State { get; set; }
        public Memeto CreateMemeto()
        {
            return new Memeto(State);
        }
        public void SetMemeto(Memeto memeto)
        {
            State = memeto.State;
        }
        public void Show()
        {
            Console.WriteLine("State:" + State);
        }
    }
}
