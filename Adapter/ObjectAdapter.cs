using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class ObjectAdapter : Target
    {
        private ObjectAdaptee adaptee;
        public ObjectAdapter(ObjectAdaptee objectAdaptee) 
        {
            adaptee = objectAdaptee;
        }
        
        public override void Request()
        {
            adaptee.SpecificRequest();
        }
    }
}
