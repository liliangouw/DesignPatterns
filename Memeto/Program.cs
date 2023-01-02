namespace Memeto
{
    /// <summary>
    /// 备忘录模式
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            originator.State = "On";
            originator.Show();
            //创建管理者
            Caretaker caretaker= new Caretaker();
            //将备忘录给管理者
            caretaker.Memeto=originator.CreateMemeto();
            originator.State = "Off";
            originator.Show();
            //将备份恢复
            originator.SetMemeto(caretaker.Memeto);
            originator.Show();
            Console.ReadKey();
        }
    }
}