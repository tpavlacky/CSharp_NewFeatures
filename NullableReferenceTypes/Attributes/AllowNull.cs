using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace NullableReferenceTypes.Attributes
{
	internal class AllowNull
	{
#nullable disable
		private class PreCSharp8API
		{
			public string Name { get; set; }
		}

#nullable enable
		private class CSharp8API
		{
			private string _innerValue = string.Empty;

			/*Since we always make sure that we get no null value with the getter, I’d like the type to remain string. 
			  But we want to still accept null values for backwards compatibility.
			  The AllowNull attribute lets you specify that the setter accepts null values.*/

			//The AllowNull attribute allows callers to pass null even if the type doesn’t allow it. (back compatibility)
			[AllowNull]
			public string Name
			{
				get
				{
					return _innerValue;
				}
				set
				{
					_innerValue = value ?? string.Empty;
				}
			}
		}

		private void TestMethod1(CSharp8API input)
		{
			input.Name = null; //Allowed because of AllowNull attribute - Without AllowNull this would cause a warning
		}

		private void TestMethod2(CSharp8API input)
		{
			Console.WriteLine(input.Name.ToString()); //No warning 
		}
	}
}
