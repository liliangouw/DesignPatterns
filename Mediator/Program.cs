namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator mediator=new ConcreteMediator();

            ConcreteColleague1 colleague1 = new ConcreteColleague1(mediator);
            ConcreteColleague2 colleague2 = new ConcreteColleague2(mediator);

            mediator.ConcreteColleague1 = colleague1;
            mediator.ConcreteColleague2= colleague2;

            colleague1.Send("吃饭了没？");
            colleague2.Send("没吃呢，你请客？");

            Console.ReadKey();
        }
    }
}