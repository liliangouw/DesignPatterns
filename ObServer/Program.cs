namespace ObServer
{
    /// <summary>
    /// 观察者模式
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject concreteSubject=new ConcreteSubject();
            ConcreteObserver concreteObserver1 = new ConcreteObserver("A",concreteSubject);
            ConcreteObserver2 concreteObserver2 = new ConcreteObserver2("B", concreteSubject);
            ConcreteObserver2 concreteObserver3 = new ConcreteObserver2("C", concreteSubject);
            concreteSubject.Update += new EventHandler(concreteObserver1.CloseNBA);
            concreteSubject.Update += new EventHandler(concreteObserver2.CloseGuPiao);
            concreteSubject.Update += new EventHandler(concreteObserver3.CloseGuPiao);
            concreteSubject.SubjectState = "老板来了";
            concreteSubject.Notify();
            Console.ReadKey();
        }
    }
}