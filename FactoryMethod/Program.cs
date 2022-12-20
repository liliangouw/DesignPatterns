using FactoryMethod.Factory;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory databaseFactory = new DatabaseFactory();
            AbstractLog datalog= databaseFactory.CreateLog();
            datalog.WriteLog();

            AbstractFactory fileFactory = new FileFactory();
            AbstractLog fileLog = fileFactory.CreateLog();
            fileLog.WriteLog();

            Console.ReadKey();
        }
    }
}