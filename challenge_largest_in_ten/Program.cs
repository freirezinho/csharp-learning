using System;

namespace challenge_largest_in_ten
{
  class Program
  {
    static void Main(string[] args)
    {
      int num = 0;
      int odds = 0;
      int evens = 0;
      Console.WriteLine("Let's count even and odd numbers in 10. Let's start: ");
      for (int i = 0; i <= 10; i++)
      {
        Console.WriteLine("Type a number: ");
        num = Convert.ToInt32(Console.ReadLine());
        if (num % 2 == 0)
        {
          evens++;
        }
        else
        {
          odds++;
        }
      }
      Console.WriteLine("Evens: {0}", evens);
      Console.WriteLine("Odds: {0}", odds);
    }
  }
}
