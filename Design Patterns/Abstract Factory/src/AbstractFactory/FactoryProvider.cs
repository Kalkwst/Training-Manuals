using AbstractFactory.Animals;
using AbstractFactory.Animals.Products;
using AbstractFactory.Colors;
using AbstractFactory.Colors.Products;

namespace AbstractFactory
{
	public class FactoryProvider
	{
		public static IAbstractFactory<IAnimal> GetAnimalFactory()
		{
			return new AnimalFactory();
		}

		public static IAbstractFactory<IColor> GetColorFactory()
		{
			return new ColorFactory();
		}
	}
}
