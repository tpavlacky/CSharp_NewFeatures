using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.ValueTuples
{
	internal class Accessing
	{
		public void UnNamedMembers()
		{
			// ValueTuple with three elements 
			var author = (20, "Siya", "Ruby");

			// Accessing the ValueTuple 
			// Using default Item property 
			Console.WriteLine("Age:" + author.Item1);
			Console.WriteLine("Name:" + author.Item2);
			Console.WriteLine("Language:" + author.Item3);
		}

		public void NamedMembers()
		{
			// ValueTuple with three elements 
			var library = (Book_id: 2340, Author_name: "Arundhati Roy", Book_name : "The God of Small Things");

			// Accessing the ValueTuple 
			// according to their names 
			Console.WriteLine("Book Id: {0}", library.Book_id);
			Console.WriteLine("Author Name: {0}", library.Author_name);
			Console.WriteLine("Book Name: {0}", library.Book_name);
		}
	}
}
