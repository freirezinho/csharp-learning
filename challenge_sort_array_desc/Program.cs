using System;

namespace DescArraySorting
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] arr = new int[7];
      for (int i = 0; i < 7; i++)
      {
        Console.WriteLine("Enter a number:");
        arr[i] = Convert.ToInt32(Console.ReadLine());

      }
      for (int i = 0; i < 6; i++)
      {
        for (int j = i + 1; j < 7; j++)
        {
          if (arr[j] > arr[i])
          {
            int temp;
            temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
          }
        }

      }
      for (int i = 0; i < 7; i++)
      {
        Console.Write("{0} ", arr[i]);
      }
    }
  }
}
