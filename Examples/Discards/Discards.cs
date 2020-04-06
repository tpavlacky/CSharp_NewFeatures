using System.ComponentModel.Design.Serialization;
using System.Text;
using Console = System.Console;

namespace Examples.Discards
{
  //some examples are also in PatternMatching - Examples
  public class Discards
  {
    #region out par
    public void OldSchool(string number)
    {
      int i;
      if (int.TryParse(number, out i))
      {
        //number is int but we do not need this value anymore
      }
      else
      {
        //...
      }
    }

    public void NewWay(string number)
    {
      if (int.TryParse(number, out _))
      {
        //...
      }
      else
      {
        //...
      }
    }
    #endregion

    #region with value tuples
    public (string name, string middleName, string surname) GetFullName()
    {
      return ("Karel", "", "Novak");
    }

    public void Test()
    {
      var fullName = GetFullName();
      //fullName.name
      //fullName.middleName
      //fullName.surname

      var (firstName, _, lastName) = GetFullName();
    }
    #endregion

    #region Switch statements
    public void SwitchStatementWithDiscards()
    {
      var userInfo = GetUserInfo();

      switch (userInfo)
      {
        case (25, _, _):
          Console.Write("Some 25 years old user");
          break;
        case (_, "Karel", _):
          Console.Write("This is Karel");
          break;
        default:
          Console.Write("Some random user");
          break;
      }
    }
    #endregion

    #region Switch expressions

    public string SwitchExpressionWithDiscards()
    {
      var userInfo = GetUserInfo();
      return userInfo switch
      {
        (25, _, _) => "Some random 25 years old user",
        (_, "Karel", _) => "Some Karel",
        (_, _, "Novak") => "Casual Novak",
        _ => "Some random user"
      };
    }

    #endregion

    #region _ as variable

    private void DiscardAsVariable(string number)
    {
      int _;
      if (int.TryParse(number, out _))
      {
        var result = 10 + _;
      }
      else
      {

      }
    }

    #endregion

    public (int age, string firstName, string lastName) GetUserInfo()
    {
      return (25, "Karel", "Novak");
    }
  }
}
