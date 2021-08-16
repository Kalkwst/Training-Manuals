using System;

namespace NaiveSingleton
{
	/// <summary>
	/// The Singleton class defines the `GetInstance` method that serves as an
	/// alternative to constructor and lets clients access the same instance of 
	/// this class over and over.
	/// 
	/// Note: This implementation of the singleton pattern is NOT Thread-Safe.
	/// </summary>
	class Singleton
	{
		public string SingletonId { get; }

		/// <summary>
		/// The Singleton's constructor should always be provate to prevent
		/// direct construction calls with the `new` operator.
		/// </summary>
		private Singleton() 
		{
			SingletonId = Guid.NewGuid().ToString();
		}

		/// <summary>
		/// The Singleton's instance is stored in a static field. There are
		/// multiple ways to initialize this field, all of them have various pros 
		/// and oons. In this example we'll discuss the simplest of these ways,
		/// which, however, doesn't work really well in multithreaded programs.
		/// </summary>
		private static Singleton _instance;

		/// <summary>
		/// This is the static method that controls the access to the singleton
		/// instance, On the first run, it creates a singleton object and places
		/// it into the static field. On subsequent runs, it returns the client an
		/// existing object stored in the static field
		/// </summary>
		/// <returns>The preconstructed instance</returns>
		public static Singleton GetInstance()
		{
			if (_instance == null)
			{
				_instance = new Singleton();
			}

			return _instance;
		}

		/// <summary>
		/// Finally, any singleton should define some business logic, which can
		/// be executed on its instance.
		/// </summary>
		public static void SomeBusinessLogic()
		{
			Console.WriteLine("The business logic of the singleton");
		}
	}
}
