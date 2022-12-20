namespace SimpleFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name 获取当前类名
            //Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name);

            AbstractProduct product= Factory.GetProduct("B");
            product.GetName();

            Console.ReadKey();
        }
    }
}