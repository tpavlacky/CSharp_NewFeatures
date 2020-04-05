using System.Drawing;
using System.Security.Claims;
using Examples.Classes;
using Examples.Interfaces;

namespace Examples.PatternMatching.CSharp_8
{
	internal class Property_Pattern
	{
    public void Setup()
    {
      var @object = new Audi(new PetrolEngine(), MyColor.Black);
      var oldColor = GetPrice(@object);
    }

    private static int GetPrice(ICar car)
    {
      var basePrice = 1000;
      switch (car)
      {
        case { Manufacturer: "Audi", Color: MyColor.Black }:
        {
          return basePrice + 200;
        }
        case { Manufacturer: "Skoda", Color: MyColor.Orange }:
        {
          return 0;
        }
        case { Manufacturer: "Skoda" }:
        {
          return 10;
        }
        case { Manufacturer: "Audi" }:
        {
          return 11;
        }
      }

      return basePrice;
    }
  }
}
