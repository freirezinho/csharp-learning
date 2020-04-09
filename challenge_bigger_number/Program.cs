using System;

namespace challenge_bigger_number
{
  class Program
  {
    static void OutputNum(int n)
    {
      Console.WriteLine("The largest one is {0}", n);
    }
    static void Main(string[] args)
    {
      int n1, n2, n3, bigN;
      Console.WriteLine("We'll check which of 3 numbers is the biggest.");
      Console.WriteLine("Type the first one: ");
      n1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Type the second one: ");
      n2 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Type the third one: ");
      n3 = Convert.ToInt32(Console.ReadLine());
      if (n1 > n2 && n1 > n3)
      {
        bigN = n1;
        Program.OutputNum(bigN);
      }
      else if (n2 > n1 && n2 > n3)
      {
        bigN = n2;
        Program.OutputNum(bigN);
      }
      else
      {
        bigN = n3;
        Program.OutputNum(bigN);
      }
    }
  }
}
