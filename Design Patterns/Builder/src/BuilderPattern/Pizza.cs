namespace BuilderPattern
{
	class Pizza
	{
		public PizzaDough Dough { get; set; }
		public PizzaSauce Sauce { get; set; }
		public PizzaBaseCheese BaseCheese { get; set; }
		public bool Sausage { get; set; }
		public bool Pepperoni { get; set; }
		public bool Sujuk { get; set; }
		public bool Salami { get; set; }
		public bool TurkeySlices { get; set; }
		public bool Ham { get; set; }
		public bool Bacon { get; set; }
		public bool SmokedPork { get; set; }
		public bool Olives { get; set; }
		public bool RedHotChilliPeppers { get; set; }
		public bool Korn { get; set; }
		public bool Tomato { get; set; }
		public bool GreenPeppers { get; set; }
		public bool Onion { get; set; }
		public bool Mushrooms { get; set; }
		public bool FrenchFries { get; set; }
		public bool Pineapple { get; set; }


		public Pizza(PizzaDough dough, PizzaSauce sauce, PizzaBaseCheese baseCheese)
		{
			Dough = dough;
			Sauce = sauce;
			BaseCheese = baseCheese;
		}

		// Telescopic Constructors
		public Pizza(PizzaDough dough, PizzaSauce sauce, PizzaBaseCheese baseCheese, bool sausage) 
			: this(dough, sauce, baseCheese)
		{
			Sausage = sausage;
		}

		public Pizza(PizzaDough dough, PizzaSauce sauce, PizzaBaseCheese baseCheese, bool sausage, bool pepperoni) 
			: this(dough, sauce, baseCheese, sausage)
		{
			Pepperoni = pepperoni;
		}

		// Monster Constructor

		public Pizza(
			PizzaDough dough, 
			PizzaSauce sauce, 
			PizzaBaseCheese baseCheese, 
			bool sausage, 
			bool pepperoni, 
			bool sujuk, 
			bool salami, 
			bool turkeySlices, 
			bool ham, 
			bool bacon, 
			bool smokedPork, 
			bool olives, 
			bool redHotChilliPeppers, 
			bool korn, 
			bool tomato, 
			bool greenPeppers, 
			bool onion, 
			bool mushrooms, 
			bool frenchFries, 
			bool pineapple) 
			: this(dough, sauce, baseCheese, sausage, pepperoni)
		{
			Sujuk = sujuk;
			Salami = salami;
			TurkeySlices = turkeySlices;
			Ham = ham;
			Bacon = bacon;
			SmokedPork = smokedPork;
			Olives = olives;
			RedHotChilliPeppers = redHotChilliPeppers;
			Korn = korn;
			Tomato = tomato;
			GreenPeppers = greenPeppers;
			Onion = onion;
			Mushrooms = mushrooms;
			FrenchFries = frenchFries;
			Pineapple = pineapple;
		}

		public override string ToString()
		{
			return @$"
Dough: {this.Dough},
Sauce: {this.Sauce},
Cheese: {this.BaseCheese},
Sausage: {this.Sausage},
Pepperoni: {this.Pepperoni},
Sujuk: {this.Sujuk},
Salami: {this.Salami},
Turkey Slices: {this.TurkeySlices},
Ham: {this.Ham},
Bacon: {this.Bacon},
Smoked Pork: {this.SmokedPork},
Olives: {this.Olives},
Hot Peppers: {this.RedHotChilliPeppers},
Corn: {this.Korn},
Tomato: {this.Tomato},
Green Peppers: {this.GreenPeppers},
Onion: {this.Onion},
Mushroom: {this.Mushrooms},
French Fries: {this.FrenchFries},
Pineapple: {this.Pineapple}
";
		}
	}

	public enum PizzaDough
	{
		THIN_WHEAT,
		PAN_WHEAT,
		PHILLI_WHEAT_CRUST,
		MOZZARELLA_WHEAT_CRUST,
		THIN_WHOLEGRAIN,
		PAN_WHOLEGRAIN,
		PHILLI_WHOLEGRAIN_CRUST,
		MOZZARELLA_WHOLEGRAIN_CRUST
	}

	public enum PizzaSauce
	{
		TOMATO_SAUCE,
		WHITE_SAUCE,
		MEXICAN_SAUCE,
		BBQ_SAUCE,
		NO_SAUCE
	}

	public enum PizzaBaseCheese
	{
		GOUDA,
		MOZZARELLA,
		CHEDDAR,
		CHEESEMIX_GOUDA_MOZZARELLA,
		CHEESEMIX_GOUDA_CHEDDAR,
		CHEESEMIX_MOZZARELLA_CHEDDAR,
		VEGAN_CHEESE,
		NO_CHEESE
	}
}
