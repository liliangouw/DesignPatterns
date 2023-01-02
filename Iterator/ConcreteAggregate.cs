using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class ConcreteAggregate : Aggregate
    {
        private IList<object>Items= new List<object>();
        public override Iterator GetIterator()
        {
           return new ConcreteIterator(this);
        }
        public int Count
        {
            get { return Items.Count; }
        }
        public object this[int index]
        {
            get { return Items[index]; }
            set { Items.Insert(index, value); } 
        }
    }
}
