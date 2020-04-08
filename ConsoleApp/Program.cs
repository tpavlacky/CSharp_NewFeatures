using System;
using Examples.Classes;
using Examples.Interfaces;

namespace ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
    {
			string s = (args.Length > 0) ? args[0] : null;


			#region Default interface implementation
			ICar car = new Audi(new DieselEngine(), MyColor.Black);
			car.GearUp();
			#endregion

			#region Deconstruct
			//Deconstruct
			var audi = (Audi)car;
			var (audiEngine, audiColor, audiManufacturer) = audi;
			audiEngine.GearUp();
			#endregion

			#region Value Tuples
			//value tuples
			var baseStats = audi.GetBaseStats();
			var bsColor = baseStats.color;
			var bsEngine = baseStats.engine;

			(Engine eng, MyColor col) = audi.GetBaseStats();
			eng.GearUp();
			var blue = col == MyColor.Blue;

			(var e, var c) = audi.GetBaseStats();
			e.GearUp();
			var black = col == MyColor.Black;
			#endregion

			#region Discards
			//tuples
			(Engine d_eng, _) = audi.GetBaseStats();
			d_eng.GearUp();

			//deconstruct
			(Engine dec_eng, MyColor dec_color, _) = audi;
			dec_eng.GearUp();
			var dec_orange = dec_color == MyColor.Orange;
			#endregion
		}
  }

	internal class DieselEngine : Engine
	{
		public DieselEngine()
		{
			Power = 10;
			ProtectedDescription = "";
			//PrivateProtectedDescription = "";
			InternalProtectedDescription = "";
		}
	}
}
