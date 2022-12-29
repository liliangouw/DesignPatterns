namespace FlyWeight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FlyWeightFactory flyWeightFactory= new FlyWeightFactory();
            FlyWeight flyWeight = flyWeightFactory.GetFlyWeight("X");
            FlyWeight flyWeight2 = flyWeightFactory.GetFlyWeight("Y");
            FlyWeight flyWeight3 = flyWeightFactory.GetFlyWeight("Z");
        }
    }
}