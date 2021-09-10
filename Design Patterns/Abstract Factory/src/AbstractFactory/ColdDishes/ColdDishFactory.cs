using System;

namespace AbstractFactory.ColdDishes
{
	public class ColdDishFactory
	{
		public static ColdDish GetColdDish(string coldDish)
		{
			return coldDish switch
			{
				"beefcarpaccio" => new BeefCarpaccio(),
				"beeffillettartare" => new BeefFilletTartare(),
				"crabcaesar" => new CrabCaesar(),
				_ => throw new ArgumentException($"Unknown key {coldDish}"),
			};
		}
	}
}
