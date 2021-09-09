namespace AbstractFactory.Desserts
{
	public class Parsnip : Dessert
	{
		public override string GetDishName()
		{
			return "Parsnip";
		}

		public override string GetIngredients()
		{
			return "Caramelized hazelnut/Fluid gel espresso/Hazelnut praline foam/3 months fermented parsnip ice cream";
		}

		public override double GetPrice()
		{
			return 11.00;
		}
	}
}
