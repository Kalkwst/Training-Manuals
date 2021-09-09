namespace AbstractFactory.ColdDishes
{
	public class BeefCarpaccio : ColdDish
	{
		public override string GetDishName()
		{
			return "Beef Carpaccio";
		}

		public override string GetIngredients()
		{
			return "Manouri cheese/Aged balsamic vinegar/sea salt/mustard seeds";
		}

		public override double GetPrice()
		{
			return 12.00;
		}
	}
}
