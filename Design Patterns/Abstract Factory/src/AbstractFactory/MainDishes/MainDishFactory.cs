using System;

namespace AbstractFactory.MainDishes
{
	public class MainDishFactory
	{
		public static MainDish GetMainDish(string mainDish)
		{
			return mainDish switch
			{
				"beefsparerib" => new BeefSpareRib(),
				"pork" => new Pork(),
				"salmon" => new Salmon(),
				_ => throw new ArgumentException($"Unknown key {mainDish}"),
			};
		}
	}
}
