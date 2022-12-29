namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcreteComponent concreteComponent=new ConcreteComponent();
            ConcreteDecoratorA decoratorA=new ConcreteDecoratorA();
            ConcreteDecoratorB decoratorB=new ConcreteDecoratorB();
            decoratorA.SetComponent(concreteComponent);
            decoratorB.SetComponent(decoratorA);
            decoratorB.Opeation();
            Console.ReadKey();
        }
    }
}