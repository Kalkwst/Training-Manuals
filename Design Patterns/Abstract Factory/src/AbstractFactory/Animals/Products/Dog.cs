namespace AbstractFactory.Animals.Products
{
	/// <summary>
	/// Concrete Products are created by the corresponding concrete factories.
	/// </summary>
	public class Dog : IAnimal
	{
		public string GetAnimalSound()
		{
			return "Woof";
		}

		public string GetAnimalType()
		{
			return "Dog";
		}
	}
}
