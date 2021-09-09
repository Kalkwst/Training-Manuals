namespace AbstractFactory.Colors.Products
{
	/// <summary>
	/// Concrete Products are created by the corresponding concrete factories.
	/// </summary>
	public class Green : IColor
	{
		public string GetColorName()
		{
			return "Green";
		}

		public string GetHexValue()
		{
			return "#00FF00";
		}

		public string GetRGBValue()
		{
			return "R:0, G:255, B:0";
		}
	}
}
