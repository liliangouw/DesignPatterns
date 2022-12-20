using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Factory
    {
        public static AbstractProduct GetProduct(string name)
        {
            switch (name)
            {
                case "A":return new Abstract_A();
                case "B":return new Abstract_B();
                case "C":return new Abstract_C();
                default: return new Abstract_A();
            }
        }
    }
}
