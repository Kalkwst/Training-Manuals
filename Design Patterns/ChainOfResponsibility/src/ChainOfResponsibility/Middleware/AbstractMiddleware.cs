namespace ChainOfResponsibility.Middleware
{
	/// <summary>
	/// Basic validation interface
	/// </summary>
	public abstract class AbstractMiddleware
	{
		private AbstractMiddleware Next;

		/// <summary>
		///	Subclasses will implement this method with concrete checks.
		/// </summary>
		public abstract bool Check(string email, string password);
		
		/// <summary>
		/// Builds chains of middleware objects.
		/// </summary>
		public AbstractMiddleware LinkWith(AbstractMiddleware next)
		{
			Next = next;
			return Next;
		}

		/// <summary>
		/// Runs checks on the next object in the chain or ends traversing if we're in
		/// the last object in chain.
		/// </summary>
		protected bool CheckNext(string email, string password)
		{
			if (Next == null)
			{
				return true;
			}

			return Next.Check(email, password);
		}
	}
}
