using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSafeSingleton
{
	class Singleton
	{
		public string SingletonId { get; }

		/// <summary>
		/// The Singleton's instance is stored in a static field. There are
		/// multiple ways to initialize this field, all of them have various pros 
		/// and oons. In this example we'll discuss the simple padlock method which 
		/// is thread safe.
		/// </summary>
		private static Singleton _instance;

		/// <summary>
		/// The thread will use this shared object to lock the singleton, and then
		/// check whether the instance has been created before creating a new one.
		/// This will take care of the memory barrier issue, and ensure that only one 
		/// thread will create an instance.
		/// </summary>
		private static readonly object _padlock = new object();

		private Singleton()
		{
			SingletonId = Guid.NewGuid().ToString();
		}

		/// <summary>
		/// The locking mechanism below takes care of the memory barier issue. Locking
		/// makes sure that all reads occur logically after the lock acquire, and unlocking
		/// maks sure that all writes occurs logically before the lock release.
		/// 
		/// It also ensures that only one thread will create an instance. Only one thread 
		/// can be in that part of the code at a time. By the time a second thread enters
		/// it, the first thread will have created the instance, so the expression will
		/// evaluate to false.
		/// 
		/// Note that performance suffers as a lock is acquired every time the instance 
		/// is requested.
		/// </summary>
		/// <returns>The singleton instance</returns>
		public static Singleton GetInstance()
		{
			lock (_padlock)
			{
				if (_instance == null)
				{
					_instance = new Singleton();
				}

				return _instance;
			}
		}
	}
}
