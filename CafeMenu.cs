using System.Collections.Generic;

namespace GoldBadgeConsoleApps
{
    public class CafeMenu
    {

		public class Menu
		{
			public int MealNumber { get; set; }
			public string MealName { get; set; }
			public string Description { get; set; }
			public List<string> Ingredients { get; set; }
			public string Price { get; set; }

			public Menu() { }
			public Menu(int mealNumber, string mealName, string description, List<string> ingredients, double price)
			{
				mealNumber = MealNumber;
				mealName = MealName;
				description = Description;
				ingredients = Ingredients;
				price = Price;
			}
		}

	}
}
