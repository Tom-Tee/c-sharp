using System;
class Hello
{
  static void Main(string[] args)
  {
    string hello = "Hello World!!!";
    double newWord = 00.12;
    int integer = 12;
    char test = 'a';
    bool trueOrFalse = true;
      Console.WriteLine(hello);
      Console.ReadLine();

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

  }
}
