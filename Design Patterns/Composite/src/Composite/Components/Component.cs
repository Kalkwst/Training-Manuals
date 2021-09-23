using System;

namespace CompositePattern.Components
{
	/// <summary>
	/// The base Component class declares common operations for both simple and
	/// complex objects of a composition.
	/// </summary>
	public abstract class Component
	{
		/// <summary>
		/// The base Component may implement some default behaviour or leave it to 
		/// concrete classes (by declaring the method containing the behaviour as
		/// "abstract").
		/// </summary>
		public abstract string Operation();

		/// <summary>
		/// In some cases, it would be beneficial to define the child-management
		/// operations right in the base Component class. This way, you won't
		/// need to expose any concrete component classes to other client code, 
		/// even during the object tree assembly. The downside is that these 
		/// methods will be empty for the leaf-level components.
		/// </summary>
		public virtual void Add(Component component)
		{
			throw new NotImplementedException();
		}

		public virtual void Remove(Component component)
		{
			throw new NotImplementedException();
		}

		public virtual bool IsComposite()
		{
			return true;
		}
	}
}
