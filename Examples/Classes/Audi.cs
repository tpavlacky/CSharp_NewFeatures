using System;

namespace Examples.Classes
{
	public class Audi : Car
	{
		public override string Manufacturer => "Audi";

		public Audi(Engine engine, MyColor color) : base(engine, color)
		{
		}

		public void Deconstruct(out Engine engine, out MyColor color, out string manufacturer)
		{
			engine = Engine;
			color = Color;
			manufacturer = Manufacturer;
		}

    public (Engine engine, MyColor color) GetBaseStats()
		{
			return (Engine, Color);
		}

		public void StopWorking()
		{
		}
	}
}
