namespace AbstractFactory.Desserts
{
	public class GrilledPeach : Dessert
	{
		public override string GetDishName()
		{
			return "Grilled Peach";
		}

		public override string GetIngredients()
		{
			return "Goat yogurt/Fermented peach/Lime tuile/Honey gel/Lemongrass basil sorbet";
		}

		public override double GetPrice()
		{
			return 9.00;
		}
	}
}
