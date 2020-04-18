using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndUnboxing
{
  class Program
  {
    private const int arraySize = 100000;
    public static long MethodA()
    {
      Stopwatch stopWatch = new Stopwatch();
      stopWatch.Start();
      int x = 1;
      for (int i = 0; i < arraySize; i++)
      {
        x = x + 1;
      }
      stopWatch.Stop();
      return stopWatch.ElapsedMilliseconds;
    }
    public static long MethodB()
    {
      Stopwatch stopWatch = new Stopwatch();
      stopWatch.Start();
      object x = 1;
      for (int i = 0; i < arraySize; i++)
      {
        x = (int)x + 1;
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

      Console.WriteLine("Method A perf: " + MethodADuration);
      Console.WriteLine("Method B perf: " + MethodBDuration);
      Console.WriteLine("\nMethod B is " + (1f * MethodBDuration / MethodADuration) + " times slower.");
    }
  }
}
