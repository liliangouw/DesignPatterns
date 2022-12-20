using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Meal
    {
        private string Food;
        private string Drink;

        public string GetFood()
        {
            return Food;
        }
        public string GetDrink()
        {
            return Drink;
        }
        public void SetFood(string Food)
        {
            this.Food = Food;
        }
        public void SetDrink(string Drink)
        {
            this.Drink = Drink;
        }
    }
}
