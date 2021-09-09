using System;

namespace AbstractFactory
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Select a menu option: A, B or C");
			char input = Console.ReadKey().KeyChar;

			AbstractMenuFactory factory;

			switch (input)
			{
				case 'A':
				case 'a':
					factory = new MenuAFactory();
					break;
				case 'B':
				case 'b':
					factory = new MenuBFactory();
					break;
				case 'C':
				case 'c':
					factory = new MenuCFactory();
					break;
				default:
					throw new ArgumentException($"Unknown argument {input}");
			}

			var appetizer = factory.GetAppetizer();
			var coldDish = factory.GetColdDish();
			var mainDish = factory.GetMainDish();
			var dessert = factory.GetDessert();

			Console.WriteLine("\n--------------------------------------------");
			Console.WriteLine($"Appetizer: {appetizer.GetDishName()}\n\t {appetizer.GetIngredients()}");
			Console.WriteLine($"Cold Dish: {coldDish.GetDishName()}\n\t {coldDish.GetIngredients()}");
			Console.WriteLine($"Main Dish: {mainDish.GetDishName()}\n\t {mainDish.GetIngredients()}");
			Console.WriteLine($"Dessert: {dessert.GetDishName()}\n\t {dessert.GetIngredients()}");
			Console.WriteLine($"Total Cost: {appetizer.GetPrice() + coldDish.GetPrice() + mainDish.GetPrice() + dessert.GetPrice()} €");
			Console.WriteLine("\n--------------------------------------------");


		}
	}
}
