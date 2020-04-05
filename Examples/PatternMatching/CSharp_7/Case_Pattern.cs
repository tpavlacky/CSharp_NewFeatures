using Examples.Classes;

namespace Examples.PatternMatching.CSharp_7
{
	public class Case_Pattern
	{
		public void Setup()
		{
			object @object = new Audi(new PetrolEngine(), MyColor.Black);
			Test(@object);
		}

		private void Test(object obj)
		{
			switch (obj)
			{
				case Audi audi when audi.Color == MyColor.Black:
					{
						//black audi
						break;
					}

				case Audi petrolAudi when petrolAudi.Engine is PetrolEngine:
					{
						//petrol audi
						break;
					}

				case Audi _:
					{
						//some random audi
						break;
					}

				case Skoda uglySkoda when uglySkoda.Color == MyColor.Orange:
					{
						//some ugly Skoda
						break;
					}

				case Skoda _:
					{
						//who cares
						break;
					}

				case null:
					{
						break;
					}

				default:
					{
						break;
					}
			}
		}
	}
}
