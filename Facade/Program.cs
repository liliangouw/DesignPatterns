namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Facade facade=new Facade();
            facade.MethodA();
            facade.MethodB();
            facade.MethodC();
            Console.ReadLine();
        }
    }
}