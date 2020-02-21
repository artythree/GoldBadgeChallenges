using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CafeUnitTest.UnitTest1;
using static GoldBadgeConsoleApps.CafeMenu;
using Menu = GoldBadgeConsoleApps.CafeMenu.Menu;

namespace GoldBadgeConsoleApps
{
    class CafeUI
    {

        public List<Menu> _menu = new List<Menu>();


        public void Run()
        {
            RunMenu();
        }
        private void RunMenu()
        {
            bool basecase = true;
            while (basecase)
            {
                Console.Clear();

                Console.WriteLine("Welcome to the Komodo Cafe Menu System.\n" +
                    "please select one of the following options\n" +
                    "1) Show all Menu Items. \n" +
                    "2) Show a Specific Item on the Menu. \n" +
                    "3) Add a new Item to the Menu. \n" +
                    "4) Remove an Item from the menu. \n" +
                    "5) Change an Item on the menu.\n" +
                    "6) Exit.");
                int userInput = Console.Read();
                switch (userInput)
                {
                    case 1:
                        ShowMenuItems();
                        break;
                    case 2:
                        ShowItemByName();
                        break;
                    case 3:
                        AddItem();
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        Console.Clear();
                        break;
                    default:
                        RunMenu();
                        break;
                }

            }
        }
        private void ShowMenuItems()
        {
            Console.Clear();
            List<Menu> menuDirectory = _menu;
            foreach (Menu menu in menuDirectory)
            {
                Console.WriteLine($"Meal name: {menu.MealName}\n" +
                    $"Meal name: {menu.Ingredients}\n" +
                    $"Meal name: {menu.Description}\n" +
                    $"Meal name: {menu.Price}\n" +
                    $"Meal name: {menu.MealNumber}\n");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        private void ShowItemByName()
        {
            List<Menu> menuDirectory = _menu;
            Console.WriteLine("Please enter the name of a menu item");
            string name = Console.ReadLine();
            
            foreach (Menu menu in menuDirectory)
            {
                if (menu.MealName == name)
                {
                    Console.WriteLine($"Meal name: {menu.MealName}\n" +
                    $"Meal name: {menu.Ingredients}\n" +
                    $"Meal name: {menu.Description}\n" +
                    $"Meal name: {menu.Price}\n" +
                    $"Meal name: {menu.MealNumber}\n");
                }
            }
        }
        private void AddItem()
        {
            Menu menuinput = new Menu();
            List<Menu> menuDirectory = _menu;
            Console.WriteLine("Please enter the name of the new menu item.");
            string menuname = Console.ReadLine();
            foreach (Menu menu in menuDirectory)
            {
                if (menu.MealName == menuname)
                {
                    Console.WriteLine($"Meal name taken, please enter a new one or go to main menu and select edit listing.\n" +
                        $"to return to main menu please press 1, to try again press any other key.");
                    int userinput = Console.Read();
                    if (userinput == 1)
                    {
                        RunMenu();
                    }
                    else
                    {
                        AddItem();
                    }
                }
            }
            menuinput.MealName = menuname;
            Console.WriteLine("Please enter the the list of ingredients for the new menu item.");
            List<string> menuIngredients = new List<string>();
            bool cont = true;
            while (cont)
            {
                menuIngredients.Add(Console.ReadLine());
                Console.WriteLine("Would you like to add another ingredient? Type yes to continue.");
                string userInput = Console.ReadLine().ToLower();
                if (userInput != "yes")
                {
                    cont = false;
                }
            }
            menuinput.Ingredients = menuIngredients;
            cont = true;
            Console.WriteLine("Please enter a description for the new Menu Item.");
            while (cont)
            {
                string userInput = Console.ReadLine();
                Console.WriteLine($"Your description is:\n" +
                    $"{userInput}\n" +
                    $"\n" +
                    $"Are you satisfied with this description?");
                string yes = Console.ReadLine().ToLower();
                if (yes == "yes")
                {
                    cont = false;
                }
                menuinput.Description = userInput;
            }
            cont = true;
            while (cont)
            {
                string userInput = Console.ReadLine();
                Console.WriteLine($"Your price is:\n" +
                    $"{userInput}\n" +
                    $"\n" +
                    $"Are you satisfied with this price?");
                string  yes = Console.ReadLine().ToLower();
                if (yes == "yes")
                {
                    cont = false;
                }
                menuinput.Price = userInput;
            }
            menuinput.MealNumber = (menuDirectory.Count + 1);
            cont = true;
            
            Console.WriteLine($"Your new Menu Item has the attributes:\n" +
                    $"Meal name: {menuinput.MealName}\n" +
                    $"Meal name: {menuinput.Ingredients}\n" +
                    $"Meal name: {menuinput.Description}\n" +
                    $"Meal name: {menuinput.Price}\n" +
                    $"Meal name: {menuinput.MealNumber}\n" +
                    $"\n" +
                    $"Are you satisfied with these Attributes? Type yes to submit to Menu. Type anything else to start over.");
            string yesOrNo = Console.ReadLine().ToLower();
            if (yesOrNo == "yes")
            {
                cont = false;
            }
            if (cont)
            {
                AddItem();
            }
            else
            {
                _menu.Add(menuinput);
            }

        }
            
    }
}
