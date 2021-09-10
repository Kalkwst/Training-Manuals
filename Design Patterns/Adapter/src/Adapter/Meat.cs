using System;

namespace Adapter
{
	/// <summary>
	/// The Target participant, which represents details about a particular kind of meat
	/// </summary>
	public class Meat
	{
		protected string MeatName;
		protected float CookTemperatureFahrenheit;
		protected float CookTemperatureCelsius;
		protected double CaloriesPerGram;
		protected double ProteinPerGram;

		public Meat(string meat)
		{
			MeatName = meat;
		}

		public virtual void LoadData()
		{
			Console.WriteLine("\nMeat: {0} -----", MeatName);
		}
	}
}
