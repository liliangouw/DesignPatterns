namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new ConcreteStateA());
            context.Request();
            context.Request();
            context.Request();
            context.Request();
            context.Request();
            context.Request();

            Console.ReadKey();
        }
    }
}