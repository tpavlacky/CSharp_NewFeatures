using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace NullableReferenceTypes.Attributes
{
	internal class DoesNotReturnIf
	{
		public void TestMethod(string? input, string? input2)
		{
			MyAssertionLibrary.MyAssert(input != null); // if that would not be a true statement then the next method would not be invoked at all so we do not have to check for null at the next line
			var length2 = input.Length; //we know that input is not null because we just checked that in the line above... if input would be null we would not able able to reach this line

			MyAssertionLibrary.MyAssert(true); //now the next line will be invoked everytime and we are trying to approach some property on nullable type ... null check should be involved
			var length = input2.Length;

		}

		public static class MyAssertionLibrary
		{
			public static void MyAssert([DoesNotReturnIf(false)] bool condition)
			{
				if (!condition)
				{
					throw new Exception();
				}
			}
		}
	}
}
