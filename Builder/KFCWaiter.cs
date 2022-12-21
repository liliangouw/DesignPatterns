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

        /// <summary>
        /// 制定菜单
        /// </summary>
        /// <param name="mealBuilder"></param>
        public void SetMealBuilder(MealBuilder mealBuilder)
        {
            this.mealBuilder = mealBuilder;
        }
        /// <summary>
        /// 创建菜单里的菜品
        /// </summary>
        public void Construct()
        {
            this.mealBuilder.BuildFood();
            this.mealBuilder.BuildDrink();
        }
    }
}
