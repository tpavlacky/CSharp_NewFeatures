using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.NullForgivingOperator
{
	public class Person
	{
		public Person(string name) => Name = name ?? throw new ArgumentNullException(nameof(name));

		public string Name { get; }

		public void TestMethod()
		{
			var person = new Person(null);

			Person? p = GetPerson();
			if (IsValid(p))
			{
				Console.WriteLine($"Found {p!.Name}");
			}
		}

		public static bool IsValid(Person? person)
		{
			return person != null && !string.IsNullOrEmpty(person.Name);
		}

		private Person GetPerson()
		{
			return null;
		}
	}
}
