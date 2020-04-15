using System;

namespace CalculatorClass
{
  class Calculator
  {
    public int AddNumber(int n1, int n2)
    {
      int result;
      result = n1 + n2;
      return result;
    }
    static void Main(string[] args)
    {
      Calculator cal = new Calculator();
      int value = cal.AddNumber(10, 20);
      Console.WriteLine("The result is {0}", value);
      Console.ReadLine();
    }
  }
}
