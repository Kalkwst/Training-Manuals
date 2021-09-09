namespace AbstractFactory.Appetizers
{
	public abstract class Appetizer
	{
		public abstract string GetDishName();
		public abstract string GetIngredients();
		public abstract double GetPrice();
	}
}
