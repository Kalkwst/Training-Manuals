using AbstractFactory.Animals.Products;
using AbstractFactory.Colors.Products;
using System;

namespace AbstractFactory
{
	class Program
	{
		static void Main(string[] args)
		{
			IAbstractFactory<IAnimal> animalFactory = FactoryProvider.GetAnimalFactory();
			IAnimal toy = animalFactory.Create("Dog");

			IAbstractFactory<IColor> colorFactory = FactoryProvider.GetColorFactory();
			IColor color = colorFactory.Create("White");

			string result = $"A {toy.GetAnimalType()} of color {color.GetColorName()} sounds like {toy.GetAnimalSound()}";
			Console.WriteLine(result);
		}
	}
}
