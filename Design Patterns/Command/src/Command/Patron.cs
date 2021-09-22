using Command.Commands;

namespace Command
{
	/// <summary>
	/// The Invoker class
	/// </summary>
	public class Patron
	{
		private OrderCommand orderCommand;
		private MenuItem menuItem;
		private FastFoodOrder order;

		public Patron()
		{
			order = new FastFoodOrder();
		}

		public void SetCommand(int commandOption)
		{
			orderCommand = new CommandFactory().GetCommand(commandOption);
		}

		public void SetMenuItem (MenuItem item)
		{
			menuItem = item;
		}

		public void ExecuteCommand()
		{
			order.ExecuteCommand(orderCommand, menuItem);
		}

		public void ShowCurrentOrder()
		{
			order.ShowCurrentItems();
		}
	}
}
