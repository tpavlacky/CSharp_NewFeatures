using CSharp_NewFeatures.Classes;
using Examples.Classes;
using Examples.Interfaces;
using System;

namespace ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Default interface implementation
			ICar car = new Audi(new DieselEngine(), Color.Black);
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

			(Engine eng, Color col) = audi.GetBaseStats();
			eng.GearUp();
			var blue = col == Color.Blue;

			(var e, var c) = audi.GetBaseStats();
			e.GearUp();
			var black = col == Color.Black;
			#endregion

			#region Discards
			//tuples
			(Engine d_eng, _) = audi.GetBaseStats();
			d_eng.GearUp();

			//deconstruct
			(Engine dec_eng, Color dec_color, _) = audi;
			dec_eng.GearUp();
			var dec_orange = dec_color == Color.Orange;
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
