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
	}
}
