﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Abstraction
    {
        protected Implementor implementor;
        public void SetImplentor(Implementor implementor)
        {
            this.implementor = implementor;
        }
        public virtual void Operation()
        {
            implementor.OperationImp();
        }
    }
}
