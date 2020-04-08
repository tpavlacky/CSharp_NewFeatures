using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using Examples.Classes;
using Examples.Interfaces;

namespace Examples.NullableReferenceTypes
{
  internal class CarDealership
  {
    private List<ICar> _cars = new List<ICar>();

    public void BuyCar(ICar car)
    {
      //needs to be enabled in project file
      //<Nullable>enable</Nullable>
      if (car.SPZ.Length == 0)
      {
        car.SPZ = "000 0000";
      }



      //null forgiving operator
      //if (car.SPZ!.Length == 0)
      //{
      //	car.SPZ = "000 0000";
      //}

      _cars.Add(car);
    }

    private void Test(string[] args)
    {
      string s2 = (args.Length > 0) ? args[0] : null;

      M(s2);
      if (IsNullOrEmpty(s2))
      {
        var length = s2.Length;
      }
      else
      {
        var length = s2.Length;
      }

      string s3 = (args.Length > 0) ? args[0] : null;
      if (IsNullOrEmpty(s3))
      {
        var aaa = GetFileName(s3);
        var ll = aaa.Length;
      }
      else
      {
        var aaa = GetFileName(s3);
        var ll = aaa.Length;
      }

      #nullable disable
      string s = (args.Length > 0) ? args[0] : null;
      M(s);
      #nullable restore
    }

    private void M(string s)
    {

    }

    private static bool IsNullOrEmpty([NotNullWhen(false)] string? value)
    {
      if (value == null || value == "")
      {
        return true;
      }

      return false;
    }

    [return: NotNullIfNotNull("path")]
    private static string? GetFileName(string? path)
    {
      return path;
    }
  }
}
