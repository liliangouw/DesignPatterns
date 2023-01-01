using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Composite : Component
    {
        private List<Component> children=new List<Component>();
        public Composite(string name):base(name) { }

        public override void Add(Component component)
        {
            children.Add(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
            foreach (var item in children)
            {
                item.Display(depth + 2);
            }
        }

        public override void Remove(Component component)
        {
            children.Remove(component);
        }
    }
}
