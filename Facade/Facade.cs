using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Facade
    {
        SystemOne systemOne;
        SystemTwo systemTwo;
        SystemThree systemThree;
        SystemFour systemFour;
        public Facade()
        {
            systemOne = new SystemOne();
            systemTwo = new SystemTwo();
            systemThree = new SystemThree();
            systemFour= new SystemFour();
        }
        public void MethodA()
        {
            systemOne.MethodOne();
            systemTwo.MethodTwo();
        }
        public void MethodB()
        {
            systemThree.MethodThree();
            systemFour.MethodFour();
        }
        public void MethodC()
        {
            systemOne.MethodOne();
            systemThree.MethodThree();
        }
    }
}
