﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class ConcreteClassB:AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("具体类B方法1的实现");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("具体类B方法2的实现");
        }
    }
}
