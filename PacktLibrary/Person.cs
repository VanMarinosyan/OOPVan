using System.Collections.Generic;
using static System.Console;

namespace Packt.Shared;
public partial class Person
{
    public string? Name;
    public DateTime DateOfBirth;
    public WondersOfTheAncientWorld FavoriteAncientWonder;
    public WondersOfTheAncientWorld BucketList;
    public List<Person> Children = new List<Person>();
    public const string Species = "Homo Sapien";
    public readonly string HomePlanet = "Earth";
    public readonly DateTime Instantiated;
    public Person()
    {
        Name = "Unknown";
        Instantiated = DateTime.Now;
    }
    public Person(string initialName, string homePlanet)
    {
        Name = initialName;
        HomePlanet = homePlanet;
        Instantiated = DateTime.Now;
    }
    public (string, int) GetFruit()
    {
        return ("Apples", 5);
    }

    public string SayHello()
    {
        return $"{Name} says 'Hello!'";
    }

    public string SayHelloTo(string name)
    {
        return $"{Name} says 'Hello {name}!";
    }

    public string OptionalParametrs(
      string command = "Run!",
      double number = 0.0,
      bool active = true)
    {
        return string.Format(
          format: " command is {0}, number is {1}, active is {2}",
          arg0: command,
          arg1: number,
          arg2: active);

    }

    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
    }

    public override string ToString()
    {
        return $"{Name} is a {base.ToString()}";
    }
}





