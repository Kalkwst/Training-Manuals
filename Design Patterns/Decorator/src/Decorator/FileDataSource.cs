using System;
using System.IO;

namespace Decorator
{
	public class FileDataSource : IDataSource
	{
		private readonly string path;

		public FileDataSource(string path)
		{
			this.path = path;
		}

		public string ReadData()
		{
			if (!File.Exists(path))
			{
				throw new FileNotFoundException($"Could not find file {path}");
			}

			return File.ReadAllText(path);
		}

		public void WriteData(string data)
		{
			File.WriteAllText(path, data);
		}
	}
}
