using System;

namespace Command
{
	class Program
	{
		/// <summary>
		/// The Command pattern encapsulates as objects, allowing them to be executed by a Receiver class and kicked of 
		/// by an Invoker object. This enables more complex architectures such as CQRS (Command/Query Responsibility Segregation).
		/// </summary>
		static void Main(string[] args)
		{
			Patron patron = new Patron();
			
			patron.SetCommand(1);
			patron.SetMenuItem(new MenuItem("French fries", 2, 1.99));
			patron.ExecuteCommand();

			patron.SetCommand(1);
			patron.SetMenuItem(new MenuItem("Hamburger",2, 2/59));
			patron.ExecuteCommand();

			patron.SetCommand(1);
			patron.SetMenuItem(new MenuItem("Drink", 2, 1.19));
			patron.ExecuteCommand();

			patron.ShowCurrentOrder();

			patron.SetCommand(3);
			patron.SetMenuItem(new MenuItem("French fries", 2, 1.99));
			patron.ExecuteCommand();

			patron.ShowCurrentOrder();

			patron.SetCommand(2);
			patron.SetMenuItem(new MenuItem("Hamburger",4, 2.59));
			patron.ExecuteCommand();

			patron.ShowCurrentOrder();

			Console.ReadKey();
		}
	}
}
