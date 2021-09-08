using System;

namespace BuilderPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			Pizza UglySpecialPizza = new Pizza(
				PizzaDough.PHILLI_WHEAT_CRUST,
				PizzaSauce.TOMATO_SAUCE,
				PizzaBaseCheese.CHEESEMIX_GOUDA_MOZZARELLA,
				false,
				false,
				false,
				false,
				false,
				true,
				true,
				false,
				false,
				false,
				false,
				true,
				true,
				false,
				true,
				false,
				false
				);

			Pizza PizzaWithBuilder = new PizzaBuilder()
				.AddPizzaDough(PizzaDough.PHILLI_WHEAT_CRUST)
				.AddPizzaSauce(PizzaSauce.TOMATO_SAUCE)
				.AddPizzaCheese(PizzaBaseCheese.CHEESEMIX_GOUDA_MOZZARELLA)
				.AddHam()
				.AddBacon()
				.AddTomato()
				.AddGreenPeppers()
				.AddMushrooms()
				.Build();

			Console.WriteLine(UglySpecialPizza.ToString());
			Console.Write(PizzaWithBuilder.ToString());
		}
	}
}
