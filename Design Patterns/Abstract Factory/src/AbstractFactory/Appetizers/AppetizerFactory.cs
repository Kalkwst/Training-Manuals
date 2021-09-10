using System;

namespace AbstractFactory.Appetizers
{
	public class AppetizerFactory
	{
		public static Appetizer GetAppetizer(string appetizer)
		{
			return appetizer switch
			{
				"zucchini" => new Zucchini(),
				"beeftongue" => new BeefTongue(),
				"grilledsquid" => new GrilledSquid(),
				_ => throw new ArgumentException($"Unknown key {appetizer}"),
			};
		}
	}
}
