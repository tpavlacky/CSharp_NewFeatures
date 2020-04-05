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

      //(numbers ?? (numbers = new List<int>())).Add(5);
      //ICollection<int> obj = numbers;
      //int valueOrDefault = newValue.GetValueOrDefault();
      //int item;
      //if (!newValue.HasValue)
      //{
      //  valueOrDefault = 0;
      //  newValue = valueOrDefault;
      //  item = valueOrDefault;
      //}
      //else
      //{
      //  item = valueOrDefault;
      //}
      //obj.Add(item);
      //Console.WriteLine(string.Format("Added value: {0}", newValue));
    }

    private void OldSchoolWay(ref ICollection<int> numbers, int? newValue)
    {
      (numbers = numbers ?? new List<int>()).Add(5);

      numbers.Add((newValue = newValue ?? 0).Value);
      Console.WriteLine($"Added value: {newValue}");

      //ICollection<int> obj = numbers ?? new List<int>();
      //ICollection<int> collection = obj;
      //numbers = obj;
      //collection.Add(5);
      //ICollection<int> obj2 = numbers;
      //newValue = newValue.GetValueOrDefault();
      //int? num = newValue;
      //obj2.Add(num.Value);
      //Console.WriteLine(string.Format("Added value: {0}", newValue));
    }
  }
}
