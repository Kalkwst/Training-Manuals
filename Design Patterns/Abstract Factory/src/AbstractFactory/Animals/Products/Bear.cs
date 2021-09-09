namespace AbstractFactory.Animals.Products
{
	/// <summary>
	/// Concrete Products are created by the corresponding concrete factories.
	/// </summary>
	public class Bear : IAnimal
	{
		public string GetAnimalSound()
		{
			return "*Bear Sounds*";
		}

		public string GetAnimalType()
		{
			return "Bear";
		}
	}
}
