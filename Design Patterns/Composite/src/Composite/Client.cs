using CompositePattern.Components;
using System;

namespace CompositePattern
{
	public class Client
	{
		public void GetLeaf(Component leaf)
		{
			Console.WriteLine($"Result: {leaf.Operation()}");
		}

		public void AddComponent(Component component1, Component component2)
		{
			if (component1.IsComposite())
			{
				component1.Add(component2);
			}

			Console.WriteLine($"RESULT: {component1.Operation()}");
		}
	}
}
