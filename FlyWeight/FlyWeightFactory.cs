using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    public class FlyWeightFactory
    {
        private Dictionary<string, FlyWeight> flyweights= new Dictionary<string, FlyWeight>();
        public FlyWeightFactory()
        {
            flyweights.Add("X",new ContreteFlyWeight());
            flyweights.Add("Y", new ContreteFlyWeight());
            flyweights.Add("Z", new ContreteFlyWeight());
        }
        public FlyWeight GetFlyWeight(string key)
        {
            if (!flyweights.ContainsKey(key))
            {
                flyweights.Add(key, new ContreteFlyWeight());
            }
            return flyweights[key]; 
        }
    }
}
