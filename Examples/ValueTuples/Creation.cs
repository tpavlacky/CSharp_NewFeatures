using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.ValueTuples
{
	public class Creation
	{
		public void ByConstructor()
		{
			// ValueTuple with one element 
			ValueTuple<int> ValTpl1 = new ValueTuple<int>(345678);

			// ValueTuple with three elements 
			ValueTuple<string, string, int> ValTpl2 = new ValueTuple<string,
																			string, int>("C#", "Java", 586);

			// ValueTuple with eight elements 
			ValueTuple<int, int, int, int, int, int, int, ValueTuple<int>> ValTpl3 = new ValueTuple<int,
																int, int, int, int, int, int, ValueTuple<int>>(45, 67, 65, 34, 34,
																																	34, 23, new ValueTuple<int>(90));
		}

		public void ByCreateMethod()
		{
			// Creating 0-ValueTuple 
			// Using Create() Method 
			var Valtpl1 = ValueTuple.Create();

			// Creating 3-ValueTuple 
			// Using Create(T1, T2, T3) Method 
			var Valtpl2 = ValueTuple.Create(12, 30, 40, 50);

			// Creating 8-ValueTuple 
			// Using Create(T1, T2, T3, T4, T5, T6, T7, T8) Method 
			var Valtpl3 = ValueTuple.Create(34, "GeeksforGeks",'g', 'f', 'g', 56.78, 4323, "geeks");
		}

		public void ByParenthesis()
		{
			//named members
			(int age, string Aname, string Lang) author = (23, "Sonia", "C#");
			//un-named members
			var author = (age: 23, Aname: "Sonia", Lang : "C#");
		}
	}
}
