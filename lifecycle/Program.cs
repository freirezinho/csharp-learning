using System;

namespace lifecycle
{
  class Program
  {
    public Program()
    {
      Console.WriteLine("Constructor called.");
    }
    ~Program()
    {
      Console.WriteLine("Deleting...");
    }
    static void Main(string[] args)
    {
      Console.WriteLine("Main started.");
      Program p1 = new Program();
      {
        Console.WriteLine("Block Started");
        Program p2 = new Program();
        Console.WriteLine("Block ended");
      }
      Console.WriteLine("Main ended.");
    }
  }
}
