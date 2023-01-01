namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Composite root = new Composite("root");
            root.Add(new Leaf("LeafA"));
            root.Add(new Leaf("LeafB"));

            Composite comp = new Composite("CompositeX");
            comp.Add(new Leaf("LeafX-A"));
            comp.Add(new Leaf("LeafX-B"));
            root.Add(comp);

            root.Display(1);
            Console.ReadKey();
        }
    }
}