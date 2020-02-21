using System;
using System.Collections.Generic;
using static GoldBadgeConsoleApps.CafeMenu;

public class CafeRepo
{
	
	public class Repo
	{
		protected readonly List<Menu> _menu = new List<Menu>();

		public List<Menu> GetAllMenuItems()
		{
			return _menu;
		}

		public Menu GetMenuByName(string menuname)
		{
			foreach (Menu menu in _menu)
			{ 
				if (menu.MealName.ToLower() == menuname.ToLower())
				{
					return menu;
				}
			}
			return null;
		}

		public bool AddItemsToMenu(Menu menuItem)
		{
			int menuLength = _menu.Count;
			_menu.Add(menuItem);
			bool successfulAdd = (menuLength + 1 == _menu.Count);
			return successfulAdd;
		}

		public bool RemoveItemFromMenu (Menu menuItem)
		{
			int menuLength = _menu.Count;
			_menu.Remove(menuItem);
			bool successfulRemove = (menuLength - 1 == _menu.Count);
			return successfulRemove;
		}

		public bool UpdateItem(string originalName, Menu newItem)
		{
			Menu originalItem = GetMenuByName(originalName);
			if (originalItem != null)
			{
				originalItem.MealName = newItem.MealName;
				originalItem.Ingredients = newItem.Ingredients;
				originalItem.Description = newItem.Description;
				originalItem.Price = newItem.Price;
				originalItem.MealNumber = newItem.MealNumber;
				return true;
			}
			return false;
		}
	}
}
