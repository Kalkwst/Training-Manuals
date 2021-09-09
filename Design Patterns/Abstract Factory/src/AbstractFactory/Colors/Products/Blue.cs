namespace AbstractFactory.Colors.Products
{
	/// <summary>
	/// Concrete Products are created by the corresponding concrete factories.
	/// </summary>
	public class Blue : IColor
	{
		public string GetColorName()
		{
			return "Blue";
		}

		public string GetHexValue()
		{
			return "#0000FF";
		}

		public string GetRGBValue()
		{
			return "R:0, G:0, B:0";
		}
	}
}
