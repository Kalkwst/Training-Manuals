using AbstractFactory.Appetizers;
using AbstractFactory.ColdDishes;
using AbstractFactory.Desserts;
using AbstractFactory.MainDishes;

namespace AbstractFactory
{
	public abstract class AbstractMenuFactory
	{
		public abstract ColdDish GetColdDish();
		public abstract Appetizer GetAppetizer();
		public abstract MainDish GetMainDish();
		public abstract Dessert GetDessert();
	}
}
