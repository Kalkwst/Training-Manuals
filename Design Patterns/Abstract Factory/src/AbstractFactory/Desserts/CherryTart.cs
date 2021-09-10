namespace AbstractFactory.Desserts
{
	public class CherryTart : Dessert
	{
		public override string GetDishName()
		{
			return "Cherry Tart";
		}

		public override string GetIngredients()
		{
			return "Patisserie cream/Carob/Tarragon/Almond/Sour cream ice cream";
		}

		public override double GetPrice()
		{
			return 10.00;
		}
	}
}
