using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace NullableReferenceTypes.Attributes
{
#nullable enable
	internal class NotNullIfNotNull
	{
    private void PathTest(string? path)
    {
      var possiblyNullPath = MyPath.GetFileName(path);
      Console.WriteLine(possiblyNullPath.Length); // path can be null so the result of the GetFileName method can be null as well - better check this!

      if (!string.IsNullOrEmpty(path))
      {
        var goodPath = MyPath.GetFileName(path);
        Console.WriteLine(goodPath.Length); // Safe because we know that the path is not null and thanks to the NotNullIfNotNull attribute we can be sure that the result is not null either
      }
    }

    private class MyPath
    {
      // The NotNullIfNotNull(string) attribute signifies that any output value is non-null conditional on the nullability of a given parameter whose name is specified. 
      [return: NotNullIfNotNull("path")]
      public static string? GetFileName(string? path)
      {
        if(path == null)
        {
          return null;
        }

        return Path.GetFileName(path);
      }
    }
  }
}
