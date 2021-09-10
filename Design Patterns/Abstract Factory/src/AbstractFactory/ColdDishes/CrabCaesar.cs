namespace AbstractFactory.ColdDishes
{
	public class CrabCaesar : ColdDish
	{
		public override string GetDishName()
		{
			return "Crab Caesar";
		}

		public override string GetIngredients()
		{
			return "Soft shell crab/Mixed Greens/Caesar Sauce/Dashi/Egg";
		}

		public override double GetPrice()
		{
			return 14.00;
		}
	}
}
