using Examples.Interfaces;

namespace CSharp_NewFeatures.Classes
{
	public abstract class Car : ICar
	{
		public Engine Engine { get; protected set; }
		public MyColor Color{ get; protected set; }
		public abstract string Manufacturer { get; }

		public Car(Engine engine, MyColor color)
		{
			Engine = engine;
			Color = color;
		}

		public void Drive()
		{
		}

		public void Stop()
		{
		}
	}
}
