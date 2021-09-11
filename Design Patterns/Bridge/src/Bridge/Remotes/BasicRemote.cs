using Bridge.Devices;
using System;

namespace Bridge.Remotes
{
	public class BasicRemote : IRemote
	{
		protected IDevice device;

		public BasicRemote()
		{
		}

		public BasicRemote(IDevice device)
		{
			this.device = device;
		}

		public void ChannelDown()
		{
			Console.WriteLine("Remote Input: Channel Down");
			device.SetChannel(-1);
		}

		public void ChannelUp()
		{
			Console.WriteLine("Remote Input: Channel Up");
			device.SetChannel(1);
		}

		public void Power()
		{
			if (device.IsEnabled())
			{
				device.Disable();
			}
			else
			{
				device.Enable();
			}
		}

		public void VolumeDown()
		{
			Console.WriteLine("Remote Command: Volume Down");
			device.SetVolume(device.GetVolume() - 10);
		}

		public void VolumeUp()
		{
			Console.WriteLine("Remote Command: Volume Up");
			device.SetVolume(device.GetVolume() + 10);
		}
	}
}
