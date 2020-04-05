using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.ThrowExpressions
{
  internal class ConditionalOperator
  {
    private static void DisplayFirstNumber(string[] args)
    {
      string arg = args.Length >= 1 ? args[0] :
        throw new ArgumentException("You must supply an argument");
      if (long.TryParse(arg, out var number))
        Console.WriteLine($"You entered {number:F0}");
      else
        Console.WriteLine($"{arg} is not a number.");
    }
  }
}
