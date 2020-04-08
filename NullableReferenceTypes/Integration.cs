using System;
using System.Collections.Generic;
using System.Text;

namespace NullableReferenceTypes
{
	internal class Integration
	{
#nullable disable
		//Method which is defined in some pre-C# 8 library
		private object MaybeGetObject()
		{
			return null;
		}

#nullable enable
		//called from C# 8
		public void CallMethodFromOldCsharpLibrary()
		{
			var myObj = MaybeGetObject();
			var myString = myObj.ToString(); //no warning even though it will throw null exception -> is null valid in the "C# 7" library? We don't know ... 
			//No null-safety warning != safe code!
		}
	}
}
