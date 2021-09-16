using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Devices
{
	public class Tv : IDevice
	{
		private bool isOn = false;
		private int volume = 30;
		private int channel = 1;

		public void Disable()
		{
			isOn = false;
		}

		public void Enable()
		{
			isOn = true;
		}

		public int GetChannel()
		{
			return channel;
		}

		public int GetVolume()
		{
			return volume;
		}

		public bool IsEnabled()
		{
			return isOn;
		}

		public void PrintStatus()
		{
			Console.WriteLine("---------------------------------------");
			Console.WriteLine("| I'm a TV set.");
			Console.WriteLine("| I'm " + (isOn ? "enabled" : "disabled"));
			Console.WriteLine($"| Current Volume is {volume}%");
			Console.WriteLine($"| Current Channel is {channel}");
			Console.WriteLine("\n---------------------------------------");
		}

		public void SetChannel(int channel)
		{
			if (this.channel > 72)
			{
				this.channel = 72;
			}
			else if (this.channel < 1)
			{
				this.channel = 1;
			}
			else
			{
				this.channel += channel;
			}
		}

		public void SetVolume(int percent)
		{
			if (percent > 100)
			{
				volume = 100;
			}
			else if (percent < 0)
			{
				volume = 0;
			}
			else
			{
				volume = percent;
			}
		}
	}
}
