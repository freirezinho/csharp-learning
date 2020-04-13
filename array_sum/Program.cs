using System;


class Program
{
  static void Main(string[] args)
  {
    int[] arr = new int[10];
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
      Console.WriteLine("Enter a number:");
      arr[i] = Convert.ToInt32(Console.ReadLine());
      sum = sum + arr[i];
    }
    for (int i = 0; i < arr.Length; i++)
    {
      Console.WriteLine("{0} ", arr[i]);

    }
    Console.WriteLine("Sum of the array elements is: {0}", sum);

  }
}