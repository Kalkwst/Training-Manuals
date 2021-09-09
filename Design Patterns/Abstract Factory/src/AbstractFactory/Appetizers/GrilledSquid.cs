namespace AbstractFactory.Appetizers
{
	public class GrilledSquid : Appetizer
	{
		public override string GetDishName()
		{
			return "Grilled Squid";
		}

		public override string GetIngredients()
		{
			return "Parsnip/Chorizo/Bok choy/Fermented leeks sauce";
		}

		public override double GetPrice()
		{
			return 15.00;
		}
	}
}
