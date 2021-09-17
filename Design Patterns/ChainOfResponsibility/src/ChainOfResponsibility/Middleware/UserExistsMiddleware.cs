using System;

namespace ChainOfResponsibility.Middleware
{
	/// <summary>
	/// ConcreteHandler. Checks whether a user with the given credentials exists.
	/// </summary>
	class UserExistsMiddleware : AbstractMiddleware
	{
		private Server server;

		public UserExistsMiddleware(Server server)
		{
			this.server = server;
		}

		public override bool Check(string email, string password)
		{
			if(!server.HasEmail(email))
			{
				Console.WriteLine("This email is not registered!");
				return false;
			}

			if(!server.IsPasswordValid(email, password))
			{
				Console.WriteLine("Wrong Password!");
				return false;
			}

			return CheckNext(email, password);
		}
	}
}
