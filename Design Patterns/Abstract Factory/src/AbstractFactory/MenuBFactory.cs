using AbstractFactory.Appetizers;
using AbstractFactory.ColdDishes;
using AbstractFactory.Desserts;
using AbstractFactory.MainDishes;

namespace AbstractFactory
{
	public class MenuBFactory : AbstractMenuFactory
	{
		public override Appetizer GetAppetizer()
		{
			return AppetizerFactory.GetAppetizer("grilledsquid");
		}

		public override ColdDish GetColdDish()
		{
			return ColdDishFactory.GetColdDish("beefcarpaccio");
		}

		public override Dessert GetDessert()
		{
			return DessertFactory.GetDessert("cherrytart");
		}

		public override MainDish GetMainDish()
		{
			return MainDishFactory.GetMainDish("pork");
		}
	}
}
