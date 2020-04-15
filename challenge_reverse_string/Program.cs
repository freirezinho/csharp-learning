using System;

namespace ReverseStringChallenge
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] arr = { "C", "s", "h", "r", "a", "p" };
      int i = 5;
      Console.Write("The reverse of given string is: ");
      while (i >= 0)
      {
        Console.Write(arr[i]);
        i--;
      }
      Console.Read();
    }
  }
}
