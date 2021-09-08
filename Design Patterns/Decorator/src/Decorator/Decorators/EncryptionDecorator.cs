using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Decorator.Decorators
{
	public class EncryptionDecorator : DataSourceDecorator
	{
		private string password;
		private byte[] initVector = Encoding.ASCII.GetBytes("jsKidmshatyb4jdu");

		public EncryptionDecorator(IDataSource wrappee, string password) : base(wrappee)
		{
			this.password = password;
		}

		public override string ReadData()
		{
			return Decrypt(base.ReadData(), Encoding.UTF8.GetBytes(password));
		}

		public override void WriteData(string data)
		{
			base.WriteData(Encrypt(data, Encoding.UTF8.GetBytes(password)));
		}

		private string Decrypt(string data, byte[] password)
		{
			try
			{
				using (var rijndaelManaged =
					   new RijndaelManaged { Key = password, IV = initVector, Mode = CipherMode.CBC })
				using (var memoryStream =
					   new MemoryStream(Convert.FromBase64String(data)))
				using (var cryptoStream =
					   new CryptoStream(memoryStream,
						   rijndaelManaged.CreateDecryptor(password, initVector),
						   CryptoStreamMode.Read))
				{
					return new StreamReader(cryptoStream).ReadToEnd();
				}
			}
			catch (CryptographicException e)
			{
				Console.WriteLine("A Cryptographic error occurred: {0}", e.Message);
				return null;
			}
		}

		private string Encrypt(string data, byte[] password)
		{
			try
			{
				using (var rijndaelManaged =
					   new RijndaelManaged { Key = password, IV = initVector, Mode = CipherMode.CBC })
				using (var memoryStream = new MemoryStream())
				using (var cryptoStream =
					   new CryptoStream(memoryStream,
						   rijndaelManaged.CreateEncryptor(password, initVector),
						   CryptoStreamMode.Write))
				{
					using (var ws = new StreamWriter(cryptoStream))
					{
						ws.Write(data);
					}
					return Convert.ToBase64String(memoryStream.ToArray());
				}
			}
			catch (CryptographicException e)
			{
				Console.WriteLine("A Cryptographic error occurred: {0}", e.Message);
				return null;
			}
		}
	}
}