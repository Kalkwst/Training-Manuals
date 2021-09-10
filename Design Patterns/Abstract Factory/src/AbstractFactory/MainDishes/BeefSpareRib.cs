namespace AbstractFactory.MainDishes
{
	public class BeefSpareRib : MainDish
	{
		public override string GetDishName()
		{
			return "Beef Spare Rib";
		}

		public override string GetIngredients()
		{
			return "Eggplant/Florina peppers/Nivato cheese/Dried fig";
		}

		public override double GetPrice()
		{
			return 26.00;
		}
	}
}
