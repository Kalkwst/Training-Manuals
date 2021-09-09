namespace AbstractFactory.Animals.Products
{
	/// <summary>
	/// This declares a product family.
	/// 
	/// Each distinct product of a product family should have a base interface.
	/// All variants of the product must implement this interface.
	/// </summary>
	public interface IAnimal
	{
		public string GetAnimalType();
		public string GetAnimalSound();
	}
}
