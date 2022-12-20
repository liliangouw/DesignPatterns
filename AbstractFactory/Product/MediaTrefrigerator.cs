using AbstractFactory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Product
{
    public class MediaTrefrigerator : AbstracTrefrigerator
    {
        public override void Refrigeration()
        {
            Console.WriteLine("美的电视开始制冷");
        }
    }
}
