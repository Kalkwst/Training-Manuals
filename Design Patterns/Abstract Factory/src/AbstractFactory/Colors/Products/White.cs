namespace AbstractFactory.Colors.Products
{
	/// <summary>
	/// Concrete Products are created by the corresponding concrete factories.
	/// </summary>
	public class White : IColor
	{
		public string GetColorName()
		{
			return "White";
		}

		public string GetHexValue()
		{
			return "#FFFFFF";
		}

		public string GetRGBValue()
		{
			return "R:255, G:255, B:255";
		}
	}
}
