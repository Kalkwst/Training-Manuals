using CompositePattern.Components;
using System;

namespace CompositePattern
{
	class Program
	{
		static void Main(string[] args)
		{
			Client client = new Client();

			// This way the client code can support the simple leaf
			// components...
			Leaf leaf = new Leaf();
			Console.WriteLine("Client: I get a simple component:");
			client.GetLeaf(leaf);
			Console.WriteLine("\n");

			// ...as well as the complex composites.
			Composite tree = new Composite();
			Composite branch1 = new Composite();

			branch1.Add(new Leaf());
			branch1.Add(new Leaf());

			Composite branch2 = new Composite();

			branch2.Add(new Leaf());

			tree.Add(branch1);
			tree.Add(branch2);

			Console.WriteLine("Client: Now I've got a composite tree:");
			client.GetLeaf(tree);
			Console.WriteLine("\n");

			Console.Write("Client: I don't need to check the components classes even when managing the tree:\n");
			client.AddComponent(tree, leaf);
		}
	}
}
