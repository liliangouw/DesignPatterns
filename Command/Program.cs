namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //接收者
            Receiver receiver= new Receiver();
            //实例化命令并为命令指定接收者
            Command command=new ConcreteCommand(receiver);
            //将命令传递给请求类
            Invoker invoker= new Invoker();
            invoker.SetCommand(command);
            //发送命令
            invoker.ExecuteCommand();
            
            Console.ReadKey();
        }
    }
}