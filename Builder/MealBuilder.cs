using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class MealBuilder
    {
        public Meal meal = new();

        public abstract void BuildFood();
        public abstract void BuildDrink();

        public Meal GetMeal()
        {
            return meal;
        }
    }
}
