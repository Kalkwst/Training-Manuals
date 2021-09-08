namespace Decorator
{
	/// <summary>
	/// A simple data interface, defining read and write operations.
	/// </summary>
	public interface IDataSource
	{
		public void WriteData(string data);

		public string ReadData();
	}
}
