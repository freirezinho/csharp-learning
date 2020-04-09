using System;

namespace challenge_divisible_five
{
  class Program
  {
    static void Main(string[] args)
    {
      int n;
      Console.WriteLine("Let's see if the number you're thinking is divisible by 5.");
      Console.WriteLine("What number are you thinking of right now?");
      n = Convert.ToInt32(Console.ReadLine());
      if (n % 5 == 0)
      {
        Console.WriteLine("{0} is divisible by five!", n);
      }
      else
      {
        Console.WriteLine("{0} is not divisible by five.", n);
      }
    }
  }
}
