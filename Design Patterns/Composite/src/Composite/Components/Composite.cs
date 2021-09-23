using System.Collections.Generic;

namespace CompositePattern.Components
{
	public class Composite : Component
	{
		protected List<Component> children = new List<Component>();

		public override void Add(Component component)
		{
			children.Add(component);
		}

		public override void Remove(Component component)
		{
			children.Remove(component);
		}

		public override string Operation()
		{
			int idx = 0;
			string result = "Branch(";

			foreach(Component component in children)
			{
				result += component.Operation();
				if (idx != children.Count - 1)
				{
					 result += "+";
				}
				idx += 1;
			}

			return result += ")";
		}
	}
}
