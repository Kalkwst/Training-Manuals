using Bridge.Devices;
using System;

namespace Bridge.Remotes
{
	public class AdvancedRemote : BasicRemote
	{
		public AdvancedRemote(IDevice device) : base(device)
		{
		}

		public void Mute()
		{
			Console.WriteLine("Remote Command: Mute");
			device.SetVolume(0);
		}
	}
}
