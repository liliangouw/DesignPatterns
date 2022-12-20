using AbstractFactory.AbstractProduct;
using AbstractFactory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    public class MeidaFactory : AbstractFactory
    {
        public override AbstracTrefrigerator CreateTrefrigerator()
        {
            return new MediaTrefrigerator();
        }

        public override AbstractTV CreateTV()
        {
            return new MediaTV();
        }
    }
}
