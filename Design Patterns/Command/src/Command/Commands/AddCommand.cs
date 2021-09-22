using System;
using System.Collections.Generic;

namespace Command.Commands
{
	public class AddCommand : OrderCommand
	{
		public override void Execute(List<MenuItem> order, MenuItem newItem)
		{
			order.Add(newItem);
		}
	}
}
