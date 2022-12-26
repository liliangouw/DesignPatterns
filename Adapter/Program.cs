namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ObjectAdaptee objectAdaptee = new ObjectAdaptee();
            ObjectAdapter adapter = new ObjectAdapter(objectAdaptee);
            adapter.Request();
            Console.ReadKey();
        }
    }
}