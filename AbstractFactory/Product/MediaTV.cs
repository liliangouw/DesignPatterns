using AbstractFactory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Product
{
    public class MediaTV : AbstractTV
    {
        public override void Display()
        {
            Console.WriteLine("美的电视打开");
        }
    }
}
