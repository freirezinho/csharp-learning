using System;

namespace trycatch
{
  class Program
  {
    static void Main(string[] args)
    {
      int index, n1, n2, r;
      Console.WriteLine("Main start");

      Console.WriteLine("Enter the first number");
      n1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter the 2nd number");
      n2 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter an index number");
      index = Convert.ToInt32(Console.ReadLine());
      int[] arr = new int[5];
      try
      {
        r = n1 / n2;
        Console.WriteLine(r);
        arr[index] = 76;
        Console.WriteLine(arr[5]);
      }
      catch (IndexOutOfRangeException e)
      {
        Console.WriteLine("Index does not exist within array bounds.");
      }
      catch (DivideByZeroException e)
      {
        Console.WriteLine("You should not and cannot divide by zero.");
      }
      catch (Exception e)
      {
        Console.WriteLine("There was an Error.\n{0}", e.Message);
      }
      finally
      {
        Console.WriteLine("Finally");
      }
      Console.WriteLine("Main end.");


    }
  }
}
