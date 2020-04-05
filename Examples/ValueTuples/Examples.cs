using System;
using System.Runtime.CompilerServices;

namespace Examples.ValueTuples
{
  public class Examples
  {
    public void Test()
    {
      var fullName = GetBaseInfo();
      var name = fullName.name;
      var surname = fullName.surname;

      //ValueTuple<string, string, string> baseInfo = GetBaseInfo();
      //string item = baseInfo.Item1;
      //string item2 = baseInfo.Item3;
    }

    public void Test2()
    {
      var (name, _, lastName) = GetBaseInfo();
      var info = $"Name is {name} {lastName}";

      //ValueTuple<string, string, string> baseInfo = GetBaseInfo();
      //string item = baseInfo.Item1;
      //string item2 = baseInfo.Item3;
      //string text = "Name is " + item + " " + item2;
    }

    public void Test3()
    {
      (string firstName, string middleName, string lastName) = GetBaseInfo();
      var info = $"Name is {firstName} {middleName} {lastName}";

      //ValueTuple<string, string, string> baseInfo = GetBaseInfo();
      //string item = baseInfo.Item1;
      //string item2 = baseInfo.Item2;
      //string item3 = baseInfo.Item3;
      //string[] obj = new string[6];
      //obj[0] = "Name is ";
      //obj[1] = item;
      //obj[2] = " ";
      //obj[3] = item2;
      //obj[4] = " ";
      //obj[5] = item3;
      //string text = string.Concat(obj);
    }

    public (string name, string middleName, string surname) GetBaseInfo()
    {
      return ("Karel", "", "Novak");
    }

    //[return: TupleElementNames(new string[] {
    //  "name",
    //  "middleName",
    //  "surname"
    //})]
    //public ValueTuple<string, string, string> GetBaseInfo()
    //{
    //  return new ValueTuple<string, string, string>("Karel", "", "Novak");
    //}
  }
}
