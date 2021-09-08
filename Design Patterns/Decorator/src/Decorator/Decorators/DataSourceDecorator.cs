namespace Decorator.Decorators
{
	public class DataSourceDecorator : IDataSource
	{
		private readonly IDataSource wrappee;

		public DataSourceDecorator(IDataSource wrappee)
		{
			this.wrappee = wrappee;
		}

		public virtual string ReadData()
		{
			return wrappee.ReadData();
		}

		public virtual void WriteData(string data)
		{
			wrappee.WriteData(data);
		}
	}
}
