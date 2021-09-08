using System;
using Decorator.Decorators;

namespace Decorator
{
	class Program
	{
		static void Main(string[] args)
		{
			string record = "Hello World!";

			DataSourceDecorator processed = new CompressionDecorator(
												new EncryptionDecorator(
													new FileDataSource("out/DecoratorDump.txt"), "8UHjPgXZzXCGkhxV2QCnooyJexUzvJrO"));

			processed.WriteData(record);

			IDataSource plain = new FileDataSource("out/DecoratorDump.txt");

			Console.WriteLine("--------------------------------------");
			Console.WriteLine($"Original Data: {record}");
			Console.WriteLine($"Processed:  { processed.ReadData()}");
			Console.WriteLine($"Plain: {plain.ReadData()}");
		}
	}
}
			