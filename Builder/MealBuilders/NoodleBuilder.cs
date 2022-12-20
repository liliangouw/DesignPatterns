using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.MealBuilders
{
    public class NoodleBuilder : MealBuilder
    {
        public override void BuildDrink()
        {
            this.meal.SetDrink("可乐");
        }

        public override void BuildFood()
        {
            this.meal.SetFood("面条");
        }
    }
}
