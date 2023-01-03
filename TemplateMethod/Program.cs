namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractClass abstractClass;
            abstractClass = new ConcreteClassA();
            abstractClass.TemplateMethod();

            abstractClass = new ConcreteClassB();
            abstractClass.TemplateMethod();

            Console.ReadKey();
        }
    }
}