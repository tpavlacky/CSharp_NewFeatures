using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace NullableReferenceTypes.Attributes
{
	internal class DoesNotReturn
	{
		private void TestMethod(string? input)
		{
			ThrowArgumentNullException(input); //if that would be commented out the next line would cause a warning that input can be null and we should check that

			var length = input.Length; //does not cause warning because ThrowArgumentNullException is anotated with [DoesNotReturn] attribute so we are not able to get to this point at runtime
		}


		//The DoesNotReturn it is annotated with will signal to the compiler that no nullable analysis needs to happen after that point, since that code would be unreachable.
		[DoesNotReturn]
		public static void ThrowArgumentNullException(string? arg)
		{
			throw new ArgumentNullException(nameof(arg));
    }
	}
}
