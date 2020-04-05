using CSharp_NewFeatures.Classes;

namespace Examples.Interfaces
{
	public interface ICar
	{
		Engine Engine { get; }
		MyColor Color { get; }
		string Manufacturer { get; }

		void Drive();

		void Stop();

		//C# 8.0 Default interface methods
		void GearUp()
		{
			Engine.GearUp();
		}

		void GearDown()
		{
			Engine.GearDown();
		}
	}
}
