namespace AbstractFactory.MainDishes
{
	public class Pork : MainDish
	{
		public override string GetDishName()
		{
			return "Pork";
		}

		public override string GetIngredients()
		{
			return "Corn/Guanciale/Grilled tomatoes";
		}

		public override double GetPrice()
		{
			return 22.00;
		}
	}
}
