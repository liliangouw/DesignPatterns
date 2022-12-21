namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton instance = Singleton.GetSingleton();
            Singleton instance2= Singleton.GetSingleton();
            Console.WriteLine(instance == instance2);
            Console.ReadKey();
        }
    }
}