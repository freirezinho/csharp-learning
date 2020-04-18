using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
namespace SpeedyCollections
{
  class Program
  {
    private const int numElements = 100000;
    public static long MethodA()
    {
      ArrayList arrayList = new ArrayList();
      Stopwatch stopWatch = new Stopwatch();
      stopWatch.Start();
      for (int i = 0; i < numElements; i++)
      {
        arrayList.Add(i);
      }
      stopWatch.Stop();
      return stopWatch.ElapsedMilliseconds;
    }
    public static long MethodB()
    {
      List<int> intList = new List<int>();

      Stopwatch stopWatch = new Stopwatch();
      stopWatch.Start();
      object x = 1;
      for (int i = 0; i < numElements; i++)
      {
        intList.Add(i);
      }
      stopWatch.Stop();
      return stopWatch.ElapsedMilliseconds;
    }
    public static long MethodC()
    {
      int[] list = new int[numElements];

      Stopwatch stopWatch = new Stopwatch();
      stopWatch.Start();
      object x = 1;
      for (int i = 0; i < numElements; i++)
      {
        list[i] = i;
      }
      stopWatch.Stop();
      return stopWatch.ElapsedMilliseconds;
    }
    static void Main(string[] args)
    {
      MethodA();
      MethodB();
      MethodC();
      long MethodADuration = MethodA();
      long MethodBDuration = MethodB();
      long MethodCDuration = MethodC();

      // For 3 strings or less, + operator is faster than StringBuilder.
      Console.WriteLine("Method A perf: " + MethodADuration + " milliseconds.");
      Console.WriteLine("Method B perf: " + MethodBDuration + " milliseconds.");
      Console.WriteLine("Method C perf: " + MethodCDuration + " milliseconds.");

    }
  }
}
