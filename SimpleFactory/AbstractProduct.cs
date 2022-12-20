using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public abstract class AbstractProduct
    {
        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public abstract void GetName();
    }
}
