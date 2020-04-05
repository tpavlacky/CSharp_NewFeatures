namespace CSharp_NewFeatures.Classes
{
	public abstract class Engine
	{
		public int Power { get; set; }
		public int Torque { get; set; }
		public int Manufacturer { get; set; }

		protected string ProtectedDescription { get; set; }
		//C# 7.2
		private protected string PrivateProtectedDescription { get; set; }
		internal protected string InternalProtectedDescription { get; set; }

		public void GearUp()
		{
		}

		public void GearDown()
		{
		}
	}

	internal class PetrolEngine : Engine
	{
		public PetrolEngine()
		{
			Power = 10;
			ProtectedDescription = "";
			PrivateProtectedDescription = "";
			InternalProtectedDescription = "";
		}
	}
}
