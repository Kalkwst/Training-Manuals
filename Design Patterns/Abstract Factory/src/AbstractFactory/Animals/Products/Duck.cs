namespace AbstractFactory.Animals.Products
{
	/// <summary>
	/// Concrete Products are created by the corresponding concrete factories.
	/// </summary>
	public class Duck : IAnimal
	{
		public string GetAnimalSound()
		{
			return "Quack";
		}

		public string GetAnimalType()
		{
			return "Duck";
		}
	}
}
