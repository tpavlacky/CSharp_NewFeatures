using CSharp_NewFeatures.Classes;
using Examples.Classes;

namespace CSharp_NewFeatures.PatternMatching
{
	internal class Is_Pattern
	{
		public void Setup()
		{
			object @object = new Audi(new PetrolEngine(), MyColor.Black);
			Test(@object);
		}

		private void Test(object obj)
		{
			if (obj is Audi audi && audi.Color == MyColor.Black)
			{
				//black audi
				audi.StopWorking();
			}
			else if (obj is Audi casualAudi)
			{
				//other audi cars
				casualAudi.StopWorking();
			}
			else if (obj is Skoda skoda && skoda.Engine is PetrolEngine petrolEngine && petrolEngine.Power > 200)
			{
				//some powerfull skoda with petrol engine
				skoda.IncreaseCarPricesBecauseOfCoronaVirus();
			}
			else if(obj is Skoda casualSkoda)
			{
				casualSkoda.IncreaseCarPricesBecauseOfCoronaVirus();
			}
		}
	}
}
