using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace NullableReferenceTypes.Attributes
{
	class NotNullWhen
	{
		private void StringTest(string? s)
		{
			if (MyString.IsNullOrEmpty(s))
			{
				// we know that if IsNullOrEmpty returns null then the input parameter may be null
				Console.WriteLine(s.Length);
				return;
			}

			Console.WriteLine(s.Length); // Safe because we know that it is not null when IsNullOrEmpty returns false [NotNullWhen(false)]
		}

		private void VersionTest(string? s)
		{
			if (!MyVersion.TryParse(s, out var version))
			{
				//this generates a warning because of [NotNullWhen(true)] attribute - now its false so we dont know if that is null or not ... 
				Console.WriteLine(version.Major);
				return;
			}

			Console.WriteLine(version.Major); // Safe - [NotNullWhen(true)] - method which contains this attribute returns true so we declare that the out parameter is not null ... 
		}

		public class MyString
		{
			// True when 'value' is null
			// The NotNullWhen(bool) signifies that a parameter is not null even if the type allows it, conditional on the bool returned value of the method.
			public static bool IsNullOrEmpty([NotNullWhen(false)] string? value)
			{
				if (string.IsNullOrEmpty(value))
				{
					return true;
				}

				return false;
			}
		}

		public class MyVersion
		{
			// If it parses successfully, the Version will not be null.
			// The NotNullWhen(bool) signifies that a parameter is not null even if the type allows it, conditional on the bool returned value of the method.
			public static bool TryParse(string? input, [NotNullWhen(true)] out Version? version)
			{
				version = new Version();
				return true;
			}
		}
	}
}
