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
                case "A":return new Product_A();
                case "B":return new Product_B();
                case "C":return new Product_C();
                default: return new Product_A();
            }
        }
    }
}
