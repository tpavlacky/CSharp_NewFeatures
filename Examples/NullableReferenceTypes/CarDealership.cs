using System;
using System.Collections.Generic;
using System.Text;
using Examples.Classes;
using Examples.Interfaces;

namespace Examples.NullableReferenceTypes
{
  internal class CarDealership
  {
    private List<ICar> _cars = new List<ICar>();

    public void BuyCar(ICar car)
    {
      //needs to be enabled in project file
      //<Nullable>enable</Nullable>

      if (car.SPZ.Length == 0)
      {
        car.SPZ = "000 0000";
      }

			//null forgiving operator
			//if (car.SPZ!.Length == 0)
			//{
			//	car.SPZ = "000 0000";
			//}

			_cars.Add(car);
    }
  }
}
