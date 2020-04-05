using Examples.Interfaces;

namespace Examples.Classes
{
	public abstract class Car : ICar
	{
		public Engine Engine { get; protected set; }
		public MyColor Color{ get; protected set; }
		public abstract string Manufacturer { get; }
    public string? SPZ { get; set; }

		public Car(Engine engine, MyColor color)
		{
			Engine = engine;
			Color = color;
		}

    public void Deconstruct(out MyColor color, out string manufacturer)
    {
      color = Color;
      manufacturer = Manufacturer;
    }

    public void Drive()
		{
		}

		public void Stop()
		{
		}
	}
}
