using System;

namespace _2darrays
{
  class Program
  {

    static void Main(string[] args)
    {
      int[,] arr = new int[3, 3];
      int[,] mArray = new int[2, 4] {
          {2, 2, 2, 2},
          {3, 3, 3, 3},
      };
      Console.WriteLine("The third element on the second line is: {0}", mArray[1, 3]);
      int rowsum = 0, totsum = 0;

      for (int i = 0; i < 3; i++)
      {
        for (int j = 0; j < 3; j++)
        {
          Console.WriteLine("Enter a number");
          arr[i, j] = Convert.ToInt32(Console.ReadLine());
        }
      }
      for (int i = 0; i < 3; i++)
      {
        for (int j = 0; j < 3; j++)
        {
          Console.Write("{0} ", arr[i, j]);
          rowsum = rowsum + arr[i, j];
        }
        Console.WriteLine("Row sum is {0}", rowsum);
        totsum = totsum + rowsum;
        rowsum = 0;
        Console.WriteLine();
      }
      Console.WriteLine("Total sum is {0}", totsum);

    }
  }
}
