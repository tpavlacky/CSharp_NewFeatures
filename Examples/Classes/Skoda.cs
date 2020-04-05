using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.Classes
{
	public class Skoda : Car
	{
		public override string Manufacturer => "Skoda";

		public Skoda(Engine engine, MyColor color) : base(engine, color)
		{
		}

		public void IncreaseCarPricesBecauseOfCoronaVirus()
		{

		}
	}
}
