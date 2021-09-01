using System;
using System.Text;

namespace Prototype.Sandwiches
{
	public class Sandwich : AbstractSandwich
	{
		private string Bread { get; }
		private string Meat { get; }
		private string Cheese { get; }
		private string Veggies { get; }

		public Sandwich(string bread, string meat, string cheese, string veggies)
		{
			Bread = bread;
			Meat = meat;
			Cheese = cheese;
			Veggies = veggies;
		}

		public override AbstractSandwich Clone()
		{
			string ingredientList = GetIngredientList();
			Console.WriteLine($"Cloning sandwich with ingredients: {ingredientList}");

			return MemberwiseClone() as AbstractSandwich;
		}

		public override string ToString()
		{
			return $"Created the following sandwich: {GetIngredientList()}"; 
		}

		private string GetIngredientList()
		{
			StringBuilder builder = new StringBuilder();

			if (!string.IsNullOrWhiteSpace(Bread))
			{
				builder.Append(Bread + ", ");
			}

			if (!string.IsNullOrWhiteSpace(Meat))
			{
				builder.Append(Meat + ", ");
			}

			if (!string.IsNullOrWhiteSpace(Cheese))
			{
				builder.Append(Cheese + ", ");
			}

			if (!string.IsNullOrWhiteSpace(Veggies))
			{
				builder.Append(Veggies + ", ");
			}

			string ingredientList = builder.ToString();
			return ingredientList.Remove(ingredientList.LastIndexOf(","));
		}
	}
}
