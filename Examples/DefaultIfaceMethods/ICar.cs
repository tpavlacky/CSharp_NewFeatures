using Examples.Classes;

namespace Examples.Interfaces
{
	public interface ICar
	{
		Engine Engine { get; }
		MyColor Color { get; }
		string Manufacturer { get; }
		string SPZ { get; set; }

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
