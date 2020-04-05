using System;
using System.Collections.Generic;

namespace Examples
{
  public class Numbers
  {
    private void AddValue(ref ICollection<int> numbers, int? newValue)
    { 
      (numbers ??= new List<int>()).Add(5);
      numbers.Add(newValue ??= 0);

      Console.WriteLine($"Added value: {newValue}");
    }

    private void OldSchoolWay(ref ICollection<int> numbers, int? newValue)
    {
      (numbers = numbers ?? new List<int>()).Add(5);

      numbers.Add((newValue = newValue ?? 0).Value);
      Console.WriteLine($"Added value: {newValue}");
    }
  }
}
