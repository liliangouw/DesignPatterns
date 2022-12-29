namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Abstraction abstraction=new RefinedAbstration();
            abstraction.SetImplentor(new ConcreteImplentorA());
            abstraction.Operation();
            Console.ReadKey();
        }
    }
}