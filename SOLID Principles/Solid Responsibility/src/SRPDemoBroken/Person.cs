namespace SRPDemoBroken
{
	public class Person
	{
		private string FirstName { get; set; }
		private string LastName { get; set; }

		public Person()
		{
		}

		public Person(string firstName, string lastName)
		{
			FirstName = firstName;
			LastName = lastName;
		}
	}
}
