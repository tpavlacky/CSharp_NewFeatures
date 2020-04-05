using Examples.Classes;

namespace Examples.PatternMatching.CSharp_7
{
	internal class Is_Pattern
	{
		public void Setup()
		{
			object @object = new Audi(new PetrolEngine(), MyColor.Black);
			Test(@object);
		}

    private void OldSchool(object obj)
    {
			#region doubleCast
      if (obj is Audi)
      {
        var audi = (Audi)obj;
      }
      else if (obj is Skoda)
      {
        var skoda = (Skoda)obj;
      }
			#endregion

			#region SingleCast but still ugly
      var audi2 = obj as Audi;
      if (audi2 != null)
      {
        //...
      }
      else
      {
        var skoda2 = obj as Skoda;
        if (skoda2 != null)
        {
          //...
        }
      }
			#endregion
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
