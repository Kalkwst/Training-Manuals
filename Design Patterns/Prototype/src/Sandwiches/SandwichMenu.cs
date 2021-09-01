using System.Collections.Generic;

namespace Prototype.Sandwiches
{
	public class SandwichMenu
	{
		private Dictionary<string, AbstractSandwich> _sandwiches = new Dictionary<string, AbstractSandwich>();

		public AbstractSandwich this[string name]
		{
			get { return _sandwiches[name]; }
			set { _sandwiches.Add(name, value); }
		}
	}
}
