using AbstractFactory.Animals.Products;
using System;

namespace AbstractFactory.Animals
{
	/// <summary>
	/// Concrete Factories produce a family of products that belong to a single
	/// variant. The factory guarantees that resulting products are compatible.
	/// Note that signatures of the Concrete Factory's methods return an abstract
	/// product, while inside the method a concrete product is instantiated.
	/// 
	/// Each Concrete Factory has a corresponding product variant.
	/// </summary>
	public class AnimalFactory : IAbstractFactory<IAnimal>
	{
		public IAnimal Create(string productType)
		{
			return productType.ToLower() switch
			{
				"dog" => new Dog(),
				"duck" => new Duck(),
				"cat" => new Cat(),
				"bear" => new Bear(),
				_ => throw new ArgumentException($"Unknown product {productType}"),
			};
		}
	}
}
