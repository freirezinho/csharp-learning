using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;

namespace optimizedStringConcat
{
  class Program
  {
    private const int repetitions = 10000;


    public static long MethodA()
    {
      string s = string.Empty;
      Stopwatch stopWatch = new Stopwatch();
      stopWatch.Start();
      for (int i = 0; i < repetitions; i++)
      {
        s = s + "a";
      }
      stopWatch.Stop();
      return stopWatch.ElapsedMilliseconds;
    }
    public static long MethodB()
    {
      StringBuilder stringBuilder = new StringBuilder();
      Stopwatch stopWatch = new Stopwatch();
      stopWatch.Start();
      object x = 1;
      for (int i = 0; i < repetitions; i++)
      {
        stringBuilder.Append("a");
      }
      stopWatch.Stop();
      return stopWatch.ElapsedMilliseconds;
    }
    static void Main(string[] args)
    {
      MethodA();
      MethodB();

      long MethodADuration = MethodA();
      long MethodBDuration = MethodB();
      // For 3 strings or less, + operator is faster than StringBuilder.
      Console.WriteLine("Method A perf: " + MethodADuration + " milliseconds.");
      Console.WriteLine("Method B perf: " + MethodBDuration + " milliseconds.");
      Console.WriteLine("\nMethod B is " + (1f * MethodBDuration / MethodADuration) + " times slower.");
    }
  }
}
