using System;
using System.Threading;

namespace LazyInstantiationUsingDotNet
{
	class Program
	{
		static void Main(string[] args)
		{
			Thread process1 = new Thread(() =>
			{
				ThreadProcedure();
			});
			Thread process2 = new Thread(() =>
			{
				ThreadProcedure();
			});

			Console.WriteLine("-------- Multiple Threads -------");

			process1.Start();
			process2.Start();

			process1.Join();
			process2.Join();

			Console.WriteLine("-------- Single Thread ----------");

			Singleton s1 = Singleton.GetInstance();
			Singleton s2 = Singleton.GetInstance();

			if (s1 == s2)
			{
				Console.WriteLine("Singleton works, both variables contain the same instance.");
			}
			else
			{
				Console.WriteLine("Singleton failed, variables contain different instances.");
			}

			Console.WriteLine($"Main method Singleton1 ID: {s1.GetSingletonId()}");
			Console.WriteLine($"Main method Singleton2 ID: {s2.GetSingletonId()}");
		}

		public static void ThreadProcedure()
		{
			Singleton singleton = Singleton.GetInstance();
			Console.WriteLine($"The singleton ID is {singleton.GetSingletonId()}");
		}
	}
}
