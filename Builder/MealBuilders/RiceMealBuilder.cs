using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.MealBuilders
{
    public class RiceMealBuilder : MealBuilder
    {
        public override void BuildDrink()
        {
            this.meal.SetDrink("热水");
        }

        public override void BuildFood()
        {
            this.meal.SetFood("米饭");
        }
    }
}
