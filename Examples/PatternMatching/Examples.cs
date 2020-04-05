using Examples.Classes;
using Examples.Interfaces;

namespace Examples.PatternMatching
{
  internal class Examples
  {
    private void Test()
    {
      var car = new Skoda(new PetrolEngine(), MyColor.Orange);
      var discount = GetDiscount(car);
    }

    private static decimal GetDiscount(ICar car) =>
      (car.Color, car.Manufacturer) switch
      {
        (MyColor.Orange, "Skoda") => 100,
        (MyColor.Black, "Audi") => 0,
        (_, "Audi") => 10,
        var (color, manufacturer) when (color == MyColor.Black) && manufacturer == "Skoda" => 66,
        (MyColor.Purple, _) => 100,
        _ => 50,
      };

    private decimal GetPremiumPrice(Audi audi) =>

      audi.GetBaseStats() switch
      {
        (_, MyColor.Green) => 10,
        (_, MyColor.Yellow) => 100,
        _ => 1000
      };

    private decimal GetPrice(Car car) =>
      //deconstructor
      car switch
      {
        (MyColor.Black, "Audi") => 100,
        (MyColor.Orange, _) => 100,
        var (color, manufacturer) when (color == MyColor.Black) && manufacturer == "Skoda" => 66,
        (_, "Audi") => 100,
        (_, _) => 100,
        _ => 0
      };
  }
}
