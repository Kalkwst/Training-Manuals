namespace AbstractFactory.Animals.Products
{
	/// <summary>
	/// Concrete Products are created by the corresponding concrete factories.
	/// </summary>
	public class Cat : IAnimal
	{
		public string GetAnimalSound()
		{
			return "Meow";
		}

		public string GetAnimalType()
		{
			return "Cat";
		}
	}
}
