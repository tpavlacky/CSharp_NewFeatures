using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace NullableReferenceTypes.Attributes
{
#nullable enable
  class MaybeNull
	{
    private void TestMethod(string[] testArray)
    {
      var refType = MyArray.Find<string>(testArray, s => s == "Hello!");
      Console.WriteLine(refType.Length); // Warning: Dereference of a possibly null reference. (because of [MaybeNull] attribute)

      var valueType = MyArray.Find<int>(new int[] { 1, 2, 3 }, i => i == 3);
      var nr = valueType.ToString(); //no warning for value types
    }

    private class MyArray
    {
      // Result is the default of T if no match is found (null for reference types)
      // The MaybeNull attribute allows for a return type to be null, even if its type doesn’t allow it. 
      [return: MaybeNull]
      public static T Find<T>(T[] array, Func<T, bool> match)
      {
        return default;
      }
    }
  }
}
