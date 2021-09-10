namespace AbstractFactory.Appetizers
{
	public class BeefTongue : Appetizer
	{
		public override string GetDishName()
		{
			return "Beef Tongue";
		}

		public override string GetIngredients()
		{
			return "Padron peppers/Smoked eel/Baked garlic sauce";
		}

		public override double GetPrice()
		{
			return 13.00;
		}
	}
}
