namespace Iterator
{
    /// <summary>
    /// 迭代器模式
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate aggregate= new ConcreteAggregate();
            aggregate[0] = "对象0";
            aggregate[1] = "对象1";
            aggregate[2] = "对象2";
            aggregate[3] = "对象3";
            aggregate[4] = "对象4";
            aggregate[5] = "对象5";
            aggregate[6] = "对象6";
            Iterator iterator = new ConcreteIterator(aggregate);
            object item=iterator.First();
            while(!iterator.IsDone())
            {
                Console.WriteLine(iterator.CurrentItem());
                iterator.Next();
            }
            Console.ReadKey();
        }
    }
}