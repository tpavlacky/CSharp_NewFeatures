using System;
using System.Diagnostics.CodeAnalysis;

namespace NullableReferenceTypes.Attributes
{
#nullable enable
  internal class NotNull
	{
    private void TestMethod(string[] testArray)
    {
      MyArray.Resize<string>(ref testArray, 200);
      Console.WriteLine(testArray.Length); // Safe - because of [NotNull] attribute
    }

    private class MyArray
    {
      // Never gives back a null when called
      // The NotNull attribute disallows null results even if the type allows it. 
      public static void Resize<T>([NotNull] ref T[] array, int newSize)
      {
        //can obtain null in the array parameter but after the method is called we can be sure that array is not null anymore
        array ??= new T[0];
      }
    }
  }
}
