using System;

namespace AbstractFactory.Colors.Products
{
	/// <summary>
	/// Concrete Products are created by the corresponding concrete factories.
	/// </summary>
	public class Red : IColor
	{
		public string GetColorName()
		{
			return "Red";
		}

		public string GetHexValue()
		{
			return "#FF0000";
		}

		public string GetRGBValue()
		{
			return "R:255, G:0, B:0";
		}
	}
}
