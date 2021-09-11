using Bridge.Devices;
using Bridge.Remotes;
using System;

namespace Bridge
{
	class Program
	{
		static void Main(string[] args)
		{
			TestDevice(new Tv());
			TestDevice(new Radio());
		}

		private static void TestDevice(IDevice device)
		{
			Console.WriteLine("Tests with basic remote");
			BasicRemote basicRemote = new BasicRemote(device);
			basicRemote.Power();
			device.PrintStatus();

			Console.WriteLine("Tests with advanced remote");
			AdvancedRemote advancedRemote = new AdvancedRemote(device);
			advancedRemote.Power();
			advancedRemote.Mute();
			device.PrintStatus();
		}
	}
}
