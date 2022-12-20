using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class KFCWaiter
    {

        public MealBuilder mealBuilder;

        public void SetMealBuilder(MealBuilder mealBuilder)
        {
            this.mealBuilder = mealBuilder;
        }
        public void Construct()
        {
            this.mealBuilder.BuildFood();
            this.mealBuilder.BuildDrink();
        }
    }
}
