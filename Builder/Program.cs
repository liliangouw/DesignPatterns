using Builder;
using Builder.MealBuilders;

KFCWaiter waiter = new();
waiter.SetMealBuilder(new NoodleBuilder());
waiter.Construct();
Meal meal=waiter.mealBuilder.GetMeal();
Console.WriteLine(meal.GetFood());
Console.WriteLine(meal.GetDrink());
Console.ReadKey();
