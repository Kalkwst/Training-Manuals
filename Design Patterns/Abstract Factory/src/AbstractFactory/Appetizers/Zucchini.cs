namespace AbstractFactory.Appetizers
{
	public class Zucchini : Appetizer
	{
		public override string GetDishName()
		{
			return "Zucchini";
		}

		public override string GetIngredients()
		{
			return "Grilled zucchini/staka cheese/bottarga";
		}

		public override double GetPrice()
		{
			return 10.00;
		}
	}
}
