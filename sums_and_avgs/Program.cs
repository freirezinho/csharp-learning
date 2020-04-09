using System;

class Program
{
  static void Main(string[] args)
  {
    int num1, num2, num3, num4, num5, sum, avg;
    Console.WriteLine("Let's add numbers.");
    Console.WriteLine("Enter the first number.");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the second number.");
    num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the third number.");
    num3 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the fourth number.");
    num4 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the fifth number.");
    num5 = Convert.ToInt32(Console.ReadLine());
    sum = num1 + num2 + num3 + num4 + num5;
    avg = sum / 5;
    Console.WriteLine("The sum is: {0}", sum);
    Console.WriteLine("The average is: {0}", avg);
  }
}
