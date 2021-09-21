using System;

namespace ChainOfResponsibility.Middleware
{
	/// <summary>
	/// ConcreteHandler. Checks whether there are too many failed login requests.
	/// </summary>
	public class ThrottlingMiddleware : AbstractMiddleware
	{
		private int RequestsPerMinute;
		private int Request;
		private long CurrentTime;

		public ThrottlingMiddleware(int requestsPerMinute)
		{
			RequestsPerMinute = requestsPerMinute;
			CurrentTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
		}

		/**
		 * Note that CheckNext() call can be inserted anywhere in this method
		 * 
		 * This gives much more flexibility than a simple loop over all middleware
		 * objects. For instance, an element of a chain can change the order of 
		 * checks by running its check after all other checks.
		 **/
		public override bool Check(string email, string password)
		{
			if (DateTimeOffset.Now.ToUnixTimeMilliseconds() > CurrentTime + 60000)
			{
				Request = 0;
				CurrentTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
			}

			Request++;

			if (Request > RequestsPerMinute)
			{
				Console.WriteLine("Request limit exceeded!");
				Environment.Exit(1);
			}

			return CheckNext(email, password);
		}
	}
}
