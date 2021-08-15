namespace BuilderPattern
{
	class PizzaBuilder
	{
		private Pizza _pizza = new Pizza(
			PizzaDough.THIN_WHEAT,
			PizzaSauce.TOMATO_SAUCE,
			PizzaBaseCheese.MOZZARELLA);

		public PizzaBuilder AddPizzaDough(PizzaDough dough)
		{
			_pizza.Dough = dough;
			return this;
		}

		public PizzaBuilder AddPizzaSauce(PizzaSauce sauce)
		{
			_pizza.Sauce = sauce;
			return this;
		}

		public PizzaBuilder AddPizzaCheese(PizzaBaseCheese cheese)
		{
			_pizza.BaseCheese = cheese;
			return this;
		}

		public PizzaBuilder AddSausage()
		{
			_pizza.Sausage = true;
			return this;
		}

		public PizzaBuilder AddPepperoni()
		{
			_pizza.Pepperoni = true;
			return this;
		}

		public PizzaBuilder AddAddSujuk()
		{
			_pizza.Sujuk = true;
			return this;
		}

		public PizzaBuilder AddSalami()
		{
			_pizza.Salami = true;
			return this;
		}

		public PizzaBuilder AddTurkey()
		{
			_pizza.TurkeySlices = true;
			return this;
		}

		public PizzaBuilder AddHam()
		{
			_pizza.Ham = true;
			return this;
		}

		public PizzaBuilder AddBacon()
		{
			_pizza.Bacon = true;
			return this;
		}

		public PizzaBuilder AddSmokedPork()
		{
			_pizza.SmokedPork = true;
			return this;
		}

		public PizzaBuilder AddOlives()
		{
			_pizza.Olives = true;
			return this;
		}

		public PizzaBuilder AddHotPeppers()
		{
			_pizza.RedHotChilliPeppers = true;
			return this;
		}

		public PizzaBuilder AddCorn()
		{
			_pizza.Korn = true;
			return this;
		}

		public PizzaBuilder AddTomato()
		{
			_pizza.Tomato = true;
			return this;
		}

		public PizzaBuilder AddGreenPeppers()
		{
			_pizza.GreenPeppers = true;
			return this;
		}

		public PizzaBuilder AddOnion()
		{
			_pizza.Onion = true;
			return this;
		}

		public PizzaBuilder AddMushrooms()
		{
			_pizza.Mushrooms = true;
			return this;
		}

		public PizzaBuilder AddFrenchFries()
		{
			_pizza.FrenchFries = true;
			return this;
		}

		public PizzaBuilder AddPineapple()
		{
			_pizza.Pineapple = true;
			return this;
		}

		public Pizza Build()
			=> _pizza;
	}
}
