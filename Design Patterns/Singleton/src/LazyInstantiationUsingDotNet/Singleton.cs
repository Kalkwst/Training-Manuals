using System;

namespace LazyInstantiationUsingDotNet
{
	class Singleton
	{
		private readonly string singletonId;

		public string GetSingletonId()
		{
			return singletonId;
		}

		private Singleton()
		{
			singletonId = Guid.NewGuid().ToString();
		}

		private static readonly Lazy<Singleton> lazy
			= new Lazy<Singleton>(() => new Singleton());

		public static Singleton GetInstance()
		{
			return lazy.Value;
		}


	}
}
