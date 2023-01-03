namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context;
            context = new Context(new ConcreteStrategyA());
            context.ContextInferface();
            context = new Context(new ConcreteStrategyB());
            context.ContextInferface();
            context = new Context(new ConcreteStrategyC());
            context.ContextInferface();
            Console.ReadKey();
        }
    }
}