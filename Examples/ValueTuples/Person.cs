using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.ValueTuples
{
  public class Person
  {
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }

    public Person(string firstName, string middleName, string surname, int age)
    {
      FirstName = firstName;
      MiddleName = middleName;
      Surname = surname;
      Age = age;
    }

    public void Deconstruct(out string firstName, out string middleName, out string surname, out int age)
    {
      firstName = FirstName;
      middleName = MiddleName;
      surname = Surname;
      age = Age;
    }
  }

  public class Test
  {
    public void Example()
    {
      var person = new Person("Karel", "Pepa", "Novak", 55);
      var (firstName, _, lastName, age) = person;

      //Person person = new Person("Karel", "Pepa", "Novak", 55);
      //string firstname;
      //string middleName;
      //string surname;
      //int age;
      //person.Deconstruct(out firstname, out middleName, out surname, out age);
      //string text = firstname;
      //string text2 = surname;
      //int num = age;
    }
  }
}
