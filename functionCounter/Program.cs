using System;

namespace functionCounter
{
  class Program
  {
    static int count;

    static void CountFunction()
    {
      count++;
      Console.WriteLine("Count Function has been called {0}", count);
    }

    static void Main(string[] args)
    {
      for (int i = 0; i < 10; i++)
      {
        Program.CountFunction();
      }
    }
  }
}
