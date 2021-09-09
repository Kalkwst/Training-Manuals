using AbstractFactory.Colors.Products;
using System;

namespace AbstractFactory.Colors
{
	/// <summary>
	/// Concrete Factories produce a family of products that belong to a single
	/// variant. The factory guarantees that resulting products are compatible.
	/// Note that signatures of the Concrete Factory's methods return an abstract
	/// product, while inside the method a concrete product is instantiated.
	/// 
	/// Each Concrete Factory has a corresponding product variant.
	/// </summary>
	public class ColorFactory : IAbstractFactory<IColor>
	{
		public IColor Create(string productType)
		{
			return productType.ToLower() switch
			{
				"white" => new White(),
				"red" => new Red(),
				"green" => new Green(),
				"blue" => new Blue(),
				_ => throw new ArgumentException($"Unknown product {productType}"),
			};
		}
	}
}
