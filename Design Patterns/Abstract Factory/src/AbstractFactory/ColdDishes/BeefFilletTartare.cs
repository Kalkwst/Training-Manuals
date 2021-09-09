namespace AbstractFactory.ColdDishes
{
	public class BeefFilletTartare : ColdDish
	{
		public override string GetDishName()
		{
			return "Beef Fillet Tartare";
		}

		public override string GetIngredients()
		{
			return "Beef/Grilled tomato vinaigrette/radish/herring's eggs";
		}

		public override double GetPrice()
		{
			return 18.00;
		}
	}
}
