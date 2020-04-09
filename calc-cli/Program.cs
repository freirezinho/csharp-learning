using System;

namespace calc_cli
{
  class Program
  {
    static void Main(string[] args)
    {
      int n1, n2, r, ch;
      char tryInput;
      bool tryAgain = true;
      Console.WriteLine("Calculator");
      while (tryAgain)
      {
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Enter a number: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter another number: ");
        n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What do you wish to do with these numbers? Type the number of your operation.");
        Console.WriteLine("1: +");
        Console.WriteLine("2: -");
        Console.WriteLine("3: *");
        Console.WriteLine("4: /");
        Console.WriteLine("5: %");
        Console.WriteLine("6: exit");
        ch = Convert.ToInt32(Console.ReadLine());
        switch (ch)
        {
          case 1:
            r = n1 + n2;
            Console.WriteLine("Result: {0}", r);
            break;
          case 2:
            r = n1 - n2;
            Console.WriteLine("Result: {0}", r);
            break;
          case 3:
            r = n1 * n2;
            Console.WriteLine("Result: {0}", r);
            break;
          case 4:
            r = n1 / n2;
            Console.WriteLine("Result: {0}", r);
            break;
          case 5:
            r = n1 % n2;
            Console.WriteLine("Result: {0}", r);
            break;
          case 6:
            break;
            Console.WriteLine("Exiting...");
          default:
            break;
        }
        Console.WriteLine("Would you like to continue? [Y/N]");
        tryInput = Char.ToLower(Convert.ToChar(Console.ReadLine()));
        switch (tryInput)
        {
          case 'y':
            tryAgain = true;
            Console.WriteLine("Restarting...");
            break;
          case 'n':
            tryAgain = false;
            Console.WriteLine("Exiting...");
            break;
        }
      }
    }
  }
}
