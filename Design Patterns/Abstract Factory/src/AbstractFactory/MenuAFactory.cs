using AbstractFactory.Appetizers;
using AbstractFactory.ColdDishes;
using AbstractFactory.Desserts;
using AbstractFactory.MainDishes;

namespace AbstractFactory
{
	public class MenuAFactory : AbstractMenuFactory
	{
		public override Appetizer GetAppetizer()
		{
			return AppetizerFactory.GetAppetizer("zucchini");
		}

		public override ColdDish GetColdDish()
		{
			return ColdDishFactory.GetColdDish("crabcaesar");
		}

		public override Dessert GetDessert()
		{
			return DessertFactory.GetDessert("parnsip");
		}

		public override MainDish GetMainDish()
		{
			return MainDishFactory.GetMainDish("salmon");
		}
	}
}
