using System;
using System.Collections.Generic;

namespace AudioDeviceCmdlets.Model
{
	public class ConfigFile
	{
		public IEnumerable<AudioDevice> AudioDevices { get; set; }

		public IEnumerable<string> DevicesName ()
		{
			ICollection<string> devicesName = new List<string>();
			foreach (var device in AudioDevices) {
				devicesName.Add($"  {device.Name}");
			}

			return devicesName;
		}
	}
}
