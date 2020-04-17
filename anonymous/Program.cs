using System;

namespace anonymous
{
  class Program
  {
    delegate void CountNumbers();
    delegate int TotalNumbers(int x);
    static void Main(string[] args)
    {
      #region Standard Delegate Call
      CountNumbers countNumbersDel = Count;
      countNumbersDel();
      #endregion
      #region Anonymous Methods
      TotalNumbers totalNumbersDel = delegate (int x)
      {
        int total = 0;
        for (int i = 0; i < x; i++)
        {
          total += i;
        }
        return total;
      };
      Console.WriteLine(totalNumbersDel(5));
      #endregion
    }
    static void Count()
    {
      for (int i = 0; i < 5; i++)
      {
        Console.WriteLine(i);
      }
    }
  }
}
