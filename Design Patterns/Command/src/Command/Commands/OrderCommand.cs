using System.Collections.Generic;

namespace Command.Commands
{
	public abstract class OrderCommand
	{
		public abstract void Execute(List<MenuItem> order, MenuItem newItem);
	}
}
