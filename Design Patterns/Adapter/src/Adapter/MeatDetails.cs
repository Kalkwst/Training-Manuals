using System;

namespace Adapter
{
	/// <summary>
	/// The Adapter class, which wraps the Meat class and initializes that class's values.
	/// </summary>
	public class MeatDetails : Meat
	{
		private MeatDatabase meatDatabase;

		public MeatDetails(string meat) 
			: base(meat.ToLower())
		{
		}

		public override void LoadData()
		{
			// The Adaptee
			meatDatabase = new MeatDatabase();

			CookTemperatureFahrenheit = meatDatabase.GetCookingTemp(MeatName, TemperatureType.Fahrenheit);
			CookTemperatureCelsius = meatDatabase.GetCookingTemp(MeatName, TemperatureType.Celsius);
			CaloriesPerGram = meatDatabase.GetCaloriesPerGram(MeatName);
			ProteinPerGram = meatDatabase.GetProteinPerGram(MeatName);

			base.LoadData();
			Console.WriteLine(" Safe Cook Temp (F): {0}", CookTemperatureFahrenheit);
			Console.WriteLine(" Safe Cook Temp (C): {0}", CookTemperatureCelsius);
			Console.WriteLine(" Calories per Gram: {0}", CaloriesPerGram);
			Console.WriteLine(" Protein per Gram: {0}", ProteinPerGram);
		}
	}
}
