using System;

namespace Examples.ReadonlyMembers
{
  internal struct Point
  {
    //auto implemented getters are readonly by design
    public double X { get; set; }
    public double Y { get; set; }
    public /*readonly*/ double Distance => Math.Sqrt(X * X + Y * Y);

    //readonly on ToString() override to indicate that ToString() does not modify the inner state of the struct
    public override /*readonly*/ string ToString() =>
      $"({X}, {Y}) is {Distance} from the origin";

    //will not compile with readonly modifier
    public readonly void Translate(int xOffset, int yOffset)
    {
    //  X += xOffset;
    //  Y += yOffset;
    }
  }

  internal class TestClass
  {
    public void Test()
    {
      var point = new Point(){ X = 10, Y = 20};
      var distance = point.ToString();
    }

    private void TestWithoutReadonly()
    {
      //debug 
      Point point = default(Point);
      point.X = 10.0;
      point.Y = 20.0;
      string text = point.ToString();
    }

    private void TestWithReadonly()
    {
      //debug
      Point point = default(Point);
      point.X = 10.0;
      point.Y = 20.0;
      Point point2 = point;
      string text = point2.ToString();
    }
  }
}
