using System;

namespace ChainOfResponsibility.Middleware
{
	public class RoleCheckMiddleware : AbstractMiddleware
	{
		public override bool Check(string email, string password)
		{
			if(email.Equals("admin@example.com"))
			{
				Console.WriteLine("Hello, admin!");
				return true;
			}

			Console.WriteLine("Hello, user!");
			return CheckNext(email, password);
		}
	}
}
