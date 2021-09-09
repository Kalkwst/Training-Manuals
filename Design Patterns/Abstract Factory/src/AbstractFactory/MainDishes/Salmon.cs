namespace AbstractFactory.MainDishes
{
	public class Salmon : MainDish
	{
		public override string GetDishName()
		{
			return "Salmon";
		}

		public override string GetIngredients()
		{
			return "Celeriac/Kale/Bloody Mary";
		}

		public override double GetPrice()
		{
			return 23.00;
		}
	}
}
