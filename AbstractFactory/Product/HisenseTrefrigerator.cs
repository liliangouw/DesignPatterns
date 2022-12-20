using AbstractFactory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Product
{
    public class HisenseTrefrigerator : AbstracTrefrigerator
    {
        public override void Refrigeration()
        {
            Console.WriteLine("海信冰箱开始制冷");
        }
    }
}
