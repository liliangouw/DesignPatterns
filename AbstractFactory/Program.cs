using AbstractFactory.Factory;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory MediaFactory = new MeidaFactory();
            MediaFactory.CreateTrefrigerator().Refrigeration();
            MediaFactory.CreateTV().Display();

            AbstractFactory HisenseFactory=new HisenceFactory();
            HisenseFactory.CreateTrefrigerator().Refrigeration();
            HisenseFactory.CreateTV().Display();

            Console.ReadKey();
        }
    }
}