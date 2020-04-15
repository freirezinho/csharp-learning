using System;

class Program
{
  static void Main(string[] args)
  {
    int lastNum = 0;
    int[] NumArray = new int[5] { 2, 8, 4, 3, 7 };
    foreach (int n in NumArray)
    {
      if (n > lastNum)
      {
        lastNum = n;
      }
    }
    Console.WriteLine("{0} is the largest number in the array.", lastNum);
  }
}