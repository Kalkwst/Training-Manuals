using AbstractFactory.Appetizers;
using AbstractFactory.ColdDishes;
using AbstractFactory.Desserts;
using AbstractFactory.MainDishes;

namespace AbstractFactory
{
	public class MenuCFactory : AbstractMenuFactory
	{
		public override Appetizer GetAppetizer()
		{
			return AppetizerFactory.GetAppetizer("beeftongue");
		}

		public override ColdDish GetColdDish()
		{
			return ColdDishFactory.GetColdDish("beeffillettartare");
		}

		public override Dessert GetDessert()
		{
			return DessertFactory.GetDessert("grilledpeach");
		}

		public override MainDish GetMainDish()
		{
			return MainDishFactory.GetMainDish("beefsparerib");
		}
	}
}
