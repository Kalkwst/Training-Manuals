using System.Collections.Generic;
using System.Linq;

namespace Command.Commands
{
	/// <summary>
	/// A concrete command.
	/// </summary>
	public class RemoveCommand : OrderCommand
	{
		public override void Execute(List<MenuItem> order, MenuItem newItem)
		{
			order.Remove(order.Where(x => x.Name == newItem.Name).First());
		}
	}
}
