namespace ChainofResponsibility
{
    /// <summary>
    /// 责任链模式
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcreteHandler handler1=new ConcreteHandler();
            ConcreteHandler2 handler2=new ConcreteHandler2();
            ConcreteHandler3 handler3 = new ConcreteHandler3();
            handler1.SetSuccessor(handler2);
            handler2.SetSuccessor(handler3);
            int[]requests= { 1, 2, 5, 7, 12, 24, 23, 4, 22 };
            foreach(int request in requests)
            {
                handler1.HandleRequest(request);
            }
            Console.ReadLine();
        }
    }
}