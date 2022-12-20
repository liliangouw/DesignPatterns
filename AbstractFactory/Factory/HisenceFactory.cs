using AbstractFactory.AbstractProduct;
using AbstractFactory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    public class HisenceFactory : AbstractFactory
    {
        public override AbstracTrefrigerator CreateTrefrigerator()
        {
            return new HisenseTrefrigerator();
        }

        public override AbstractTV CreateTV()
        {
            return new HisenseTV();
        }
    }
}
