using System.Collections.Generic;
using System.Linq;

namespace Command.Commands
{
	/// <summary>
	/// A concrete command
	/// </summary>
	public class ModifyCommand : OrderCommand
	{
		public override void Execute(List<MenuItem> order, MenuItem newItem)
		{
			var item = order.Where(x => x.Name == newItem.Name).First();
			item.Price = newItem.Price;
			item.Amount = newItem.Amount;
		}
	}
}
