using System;

namespace AbstractFactory.Desserts
{
	public class DessertFactory
	{
		public static Dessert GetDessert(string dessert)
		{
			return dessert switch
			{
				"cherrytart" => new CherryTart(),
				"grilledpeach" => new GrilledPeach(),
				"parnsip" => new Parsnip(),
				_ => throw new ArgumentException($"Unknown key {dessert}"),
			};
		}
	}
}
