using System;

namespace if_else
{
  class Program
  {
    static void Main(string[] args)
    {
      int num;
      Console.WriteLine("Type a number");
      num = Convert.ToInt32(Console.ReadLine());
      if (num == 10)
      {
        Console.WriteLine("Good.");
      }
      else if (num == 20)
      {
        Console.WriteLine("Better.");
      }
      else if (num == 30)
      {
        Console.WriteLine("Best.");
      }
      else
      {
        Console.WriteLine("Invalid.");
      }
    }
  }
}
