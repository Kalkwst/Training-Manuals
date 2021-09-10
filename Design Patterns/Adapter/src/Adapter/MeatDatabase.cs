namespace Adapter
{
	/// <summary>
	/// The legacy API that needs to be converted to the new structure
	/// </summary>
	public class MeatDatabase
	{
		public float GetCookingTemp(string meat, TemperatureType temperature)
		{
			if(temperature == TemperatureType.Celsius)
			{
				switch(meat)
				{
					case "beef":
					case "veal":
					case "pork":
						return 63f;

					case "chicken":
					case "turkey":
						return 74f;

					default:
						return 74f;
				}
			}
			else
			{
				switch (meat)
				{
					case "beef":
					case "veal":
					case "pork":
						return 145f;

					case "chicken":
					case "turkey":
						return 165f;

					default:
						return 165f;
				}
			}
		}

		public double GetCaloriesPerGram(string meat)
		{
			switch(meat.ToLower())
			{
				case "beef":
					return 2.50;
				case "pork":
					return 2.43;
				case "veal":
					return 1.72;
				case "chicken":
					return 2.39;
				case "turkey":
					return 1.88;
				default:
					return 0;
			}
		}

		public double GetProteinPerGram(string meat)
		{
			switch (meat.ToLower())
			{
				case "beef":
					return 0.26;
				case "pork":
					return 0.27;
				case "veal":
					return 0.24;
				case "chicken":
					return 0.27;
				case "turkey":
					return 0.29;
				default:
					return 0;
			}
		}
	}
}
