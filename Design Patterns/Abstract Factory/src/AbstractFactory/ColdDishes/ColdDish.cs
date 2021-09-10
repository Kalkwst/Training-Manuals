namespace AbstractFactory.ColdDishes
{
	public abstract class ColdDish
	{
		public abstract string GetDishName();
		public abstract string GetIngredients();
		public abstract double GetPrice();
	}
}
