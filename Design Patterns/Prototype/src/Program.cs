using Prototype.Sandwiches;
using System;

namespace Prototype
{
	class Program
	{
		static void Main(string[] args)
		{
			SandwichMenu menu = new SandwichMenu();

			// Initialize with some default sandwiches
			menu["BLT"] = new Sandwich("Wheat", "Bacon", "", "Lettuce, Tomato");
			menu["PB&J"] = new Sandwich("Wheat", "", "", "Peanut Butter, Jelly");
			menu["Turkey"] = new Sandwich("Rye", "Turkey", "Swiss Cheese", "Lettuce, Onion, Tomato");

			// Initialize some custom sandwiches
			menu["LoadedBLT"] = new Sandwich("Wheat", "Turkey, Bacon", "Cheddar", "Lettuce, Tomato, Onion, Olives");
			menu["ThreeMeatCombo"] = new Sandwich("Rye", "Turkey, Ham, Salami", "Provolone", "Lettuce, Onion");
			menu["Vegetarian"] = new Sandwich("Wheat", "", "", "Lettuce, Onion, Tomato, Olives, Spinach");

			// Clone some sandwiches
			Sandwich sandwich1 = menu["BLT"].Clone() as Sandwich;
			Sandwich sandwich2 = menu["ThreeMeatCombo"].Clone() as Sandwich;
			Sandwich sandwich3 = menu["Vegetarian"].Clone() as Sandwich;

			Console.WriteLine($"Sandwich1: {sandwich1}");
			Console.WriteLine($"Sandwich2: {sandwich2}");
			Console.WriteLine($"Sandwich3: {sandwich3}");
		}
	}
}
