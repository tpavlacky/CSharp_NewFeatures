using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace NullableReferenceTypes.Attributes
{
#nullable enable
	internal class DisallowNull
	{
		private void TestMethod(MyHandle handle)
		{
			MyHandle? local = null; // Create a null value here
			HandleMethods.DisposeAndClear(ref local); // Warning: CS8601 - Possible null reference assignment => caused by DisallowNull attribute in the API method

			// Now pass the non-null handle
			HandleMethods.DisposeAndClear(ref handle); // No warning about possible null ref assignment ... But the value could be null after retuning from the method

			Console.WriteLine(handle.ID); // Warning: CS8602 - Dereference of a possibly null reference
		}
	}

	public static class HandleMethods
	{
		// The DisallowNull attribute disallows callers to pass null even if the type allows it.
		public static void DisposeAndClear([DisallowNull] ref MyHandle? handle)
		{
			//handle = null;
		}
	}

	public class MyHandle
	{
		public int ID { get; set; }
	}
}
