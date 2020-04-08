using System;
using System.Collections.Generic;
using System.Text;

namespace NullableReferenceTypes
{
	//https://www.youtube.com/watch?v=izVIL-9h3WE
	internal class Overview
	{
#nullable enable
		private CustomClass nonNullableField;
		private CustomClass? nullableField;

#nullable disable
		private CustomClass nonNullableField2;
#nullable restore

		public Overview() //Warning: "Non-nullable field 'nonNullableField' is unitialized" => no warning for nullableField2
		{
		}

		public string GetNameUnsafe()
		{
			var result = nonNullableField2.ToString(); //No warning - flow analysis is disabled for this field
			return nullableField.ToString(); //nullableField can be null => Warning: "Dereference of a possibly null reference" 
		}

		public string GetNameSafe()
		{
			if(nullableField != null)
			{
				return nullableField.Name; // No warning due to static flow analysis
			}

			return string.Empty;
		}

#nullable restore

		private class CustomClass
		{
			public string Name { get; set; }
		}
	}
}
