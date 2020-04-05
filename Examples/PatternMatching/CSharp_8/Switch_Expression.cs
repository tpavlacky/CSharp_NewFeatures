using System;
using System.Collections.Generic;
using System.Drawing;
using Examples.Classes;
using Examples.Interfaces;
using MyColor = Examples.Classes.MyColor;

namespace Examples.PatternMatching.CSharp_8
{
  internal class Switch_Expression
  {
    public void Setup()
    {
      var @object = new Audi(new PetrolEngine(), MyColor.Black);
      var oldColor = BeforeCSharp8(@object);
      var newColor = WithCSharp8(@object);
    }

    private static KnownColor BeforeCSharp8(ICar car)
    {
      switch (car.Color)
      {
        case MyColor.Green:
          return KnownColor.Green;
        case MyColor.Yellow:
          return KnownColor.Yellow;
        case MyColor.Blue:
          return KnownColor.Blue;
        default:
          return KnownColor.White;
      }
    }

    private static KnownColor WithCSharp8(ICar car)
    {
      return car.Color switch
      {
        MyColor.Green => KnownColor.Green,
        MyColor.Yellow => KnownColor.Yellow,
        MyColor.Blue => KnownColor.Blue,
        _ => KnownColor.White
      };
    }

    private void Examples()
    {
      //example1    
      var (a, b, option) = (10, 5, "+");

      var example1 = option switch
      {
        "+" => a + b,
        "-" => a - b,
        _ => a * b
      };
      Console.WriteLine("Example 1 : " + example1);

      //example2    
      var cal = new Calculation(10, 20, "/");
      var example2 = cal.Operation switch
      {
        "+" => cal.FirstNumber + cal.SecondNumber,
        "-" => cal.FirstNumber - cal.SecondNumber,
        _ => cal.FirstNumber * cal.SecondNumber,
      };
      Console.WriteLine("Example 2 : " + example2);
      Console.WriteLine("Property Assignment : " + cal.LogLevel);

      //example3    
      var value = 25;

      int example3 = value switch
      {
        _ when value > 10 => 0,
        _ when value <= 10 => 1
      };
      Console.WriteLine("Example 3 : " + example3);

      //example4    
      var dic = new Dictionary<string, string>();
      var (key, defaultValue) = ("Jeetendra", "C# Corner");

      var example4 = dic.TryGetValue(key, out string val) switch
      {
        false => defaultValue,
        _ => val
      };
      Console.WriteLine("Example 4 : " + example4);
    }
  }
}

public class Calculation
{
  public Calculation(int a, int b, string operation)
  {
    this.FirstNumber = a;
    this.SecondNumber = b;
    this.Operation = operation;
  }

  public int FirstNumber { get; set; }

  public int SecondNumber { get; set; }

  public string Operation { get; set; }

  public int LogLevel { get; } = Environment.GetEnvironmentVariable("LOG_LEVEL") switch
  {
    "INFO" => 1,
    "DEBUG" => 2,
    _ => 0
  };
}
