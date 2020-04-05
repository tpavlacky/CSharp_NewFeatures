using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.LocalFunctions
{
  class Fibonacci
  {
    static int Fib(int n)
    {
      if (n < 0)
        throw new ArgumentException("n must be >= 0", nameof(n));

      var memo = new Dictionary<int, int>() { { 0, 0 }, { 1, 1 } };

      return FibMemo(n);

      int FibMemo(int number)
      {
        if (memo.ContainsKey(number))
          return memo[number];

        var value = FibMemo(number - 1) + FibMemo(number - 2);
        memo[number] = value;
        return value;
      }
    }
  }
}
