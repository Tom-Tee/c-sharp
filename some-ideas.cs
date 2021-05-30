using System;
class Hello
{
  static void Main(string[] args)
  {

// VARIABLES
    string hello = "Hello World!!!";
    double newWord = 00.12;
    int integer = 12;
    char test = 'a';
    bool trueOrFalse = true;
      Console.WriteLine(hello);
      Console.ReadLine();


// CONDITIONALS
      if (hello.Length == 1) {
        Console.WriteLine("YES!");
      }
      else
      {
        Console.WriteLine("NO!");
      }

      if (integer > 10) {
        Console.WriteLine("Integer is bigger than 10");
      }
      else if (integer == 12) {
        Console.WriteLine("Integer is exactly 12!");
      }
      else
      {
        Console.WriteLine("Neither!!");
      }


// SWITCH STATEMENTS

      Console.WriteLine("Pick a genre");
      string genre = Console.ReadLine();
      switch (genre)
      {
        case "Drama":
          Console.WriteLine("Citizen Kane");
        break;
        case "Comedy":
          Console.WriteLine("Duck Soup");
        break;
        case "Adventure":
          Console.WriteLine("King Kong");
        break;
        case "Horror":
          Console.WriteLine("Psycho");
        break;
        case "Science Fiction":
          Console.WriteLine("2001: A Space Odyssey");
        break;
        default:
          Console.WriteLine("No movie found");
        break;
      }


// TERNERARY OPERATOR

        int pepperLength = 4;
        string message = (pepperLength >= 3.5) ? "ready!" : "wait a little longer";
        Console.WriteLine(message);

  }


// METHODS WITH MULTIPLE PERAMETERS
    static void someTest()
    {
      VisitPlanets(numberOfPlanets : 2, name : "Thomas");
    }

    static void VisitPlanets(
      string adjective = "brave",
      string name = "Cosmonaut",
      int numberOfPlanets = 0,
      double gForce = 4.2)
    {
      Console.WriteLine($"Welcome back, {adjective} {name}.");
      Console.WriteLine($"You visited {numberOfPlanets} new planets...");
      Console.WriteLine($"...while experiencing a g-force of {gForce} g!");
    }

    static void createArray()
    {
      string[] summerStrut;
      summerStrut = new string[] {"Juice", "Missing U", "Raspberry Boat", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles"};
    }
}
