using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memeto
{
    internal class Memeto
    {
        private string state;
        public Memeto(string state)
        {
            this.state = state;
        }
        public string State
        {
            get { return this.state; }
        }
    }
}
