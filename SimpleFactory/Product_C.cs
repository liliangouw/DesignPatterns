using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Product_C : AbstractProduct
    {
        public override void GetName()
        {
            Console.WriteLine("我是Product_C");
        }
    }
}
