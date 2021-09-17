using ChainOfResponsibility.Middleware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
	public class Server
	{
		private Dictionary<string, string> users = new Dictionary<string, string>();
		private AbstractMiddleware middleware;

		public void SetMiddleware(AbstractMiddleware middleware)
		{
			this.middleware = middleware;
		}

		public bool Login(string email, string password)
		{
			if (middleware.Check(email, password))
			{
				Console.WriteLine("Authorization have been sucessful!");
				return true;
			}

			return false;
		}

		public void Register(string email, string password)
		{
			users.Add(email, password);
		}

		public bool HasEmail(string email)
		{
			return users.ContainsKey(email);
		}

		public bool IsPasswordValid(string email, string password)
		{
			return users[email].Equals(password);
		}
	}
}
