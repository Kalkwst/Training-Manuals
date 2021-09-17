using ChainOfResponsibility.Middleware;
using System;

namespace ChainOfResponsibility
{
	class Program
	{
		private static Server server;

		private static void Init()
		{
			server = new Server();
			server.Register("admin@example.com", "admin_pass");
			server.Register("user@example.com", "user_pass");

			AbstractMiddleware middleware = new ThrottlingMiddleware(2);
			middleware.LinkWith(new UserExistsMiddleware(server))
					  .LinkWith(new RoleCheckMiddleware());

			server.SetMiddleware(middleware);
		}

		static void Main(string[] args)
		{
			Init();

			bool success;
			do
			{
				Console.WriteLine("Enter email: ");
				string email = Console.ReadLine();
				Console.WriteLine("Enter password: ");
				string password = Console.ReadLine();
				success = server.Login(email, password);

			} while (!success);
		}
	}
}
