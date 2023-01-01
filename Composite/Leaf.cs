using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {

        }
        public override void Add(Component component)
        {
            Console.WriteLine("不能添加叶节点");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth)+name);
        }

        public override void Remove(Component component)
        {
            Console.WriteLine("不能移除叶节点");
        }
    }
}
