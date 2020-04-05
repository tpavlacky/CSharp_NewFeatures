using CSharp_NewFeatures.Classes;
using Examples.Classes;
using System.Drawing;

namespace CSharp_NewFeatures.PatternMatching
{
	internal class Switch_Expression
	{
		public void Setup()
		{
			var @object = new Audi(new PetrolEngine(), MyColor.Black);
			var oldColor = BeforeCSharp8(@object);
			var newColor = WithCSharp8(@object);
		}

		private MyColor BeforeCSharp8(Car car)
		{
			switch (car.Color)
			{
				case MyColor.Green:
					break;
				case MyColor.Yellow:
					break;
				case MyColor.Blue:
					break;
				case MyColor.White:
					break;
				case MyColor.Purple:
					break;
				case MyColor.Black:
					break;
				case MyColor.Orange:
					break;
				case MyColor.Brown:
					break;
			}
		}

		private MyColor WithCSharp8(Car car)
		{

		}
	}
}
