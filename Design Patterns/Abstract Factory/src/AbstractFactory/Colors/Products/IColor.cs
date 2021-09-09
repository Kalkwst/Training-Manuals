namespace AbstractFactory.Colors.Products
{
	// <summary>
	/// This declares a product family.
	/// 
	/// Each distinct product of a product family should have a base interface.
	/// All variants of the product must implement this interface.
	/// </summary>
	public interface IColor
	{
		public string GetColorName();
		public string GetRGBValue();
		public string GetHexValue();
	}
}
