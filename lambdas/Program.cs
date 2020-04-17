using System;

namespace lambdas
{
  class Program
  {
    delegate int CountIt(int x);
    static void Main(string[] args)
    {
      #region Expression Lambda
      CountIt expressionLambda = (int x) => x + 5;
      Console.WriteLine(expressionLambda(5));
      #endregion
      #region Statement Lambda
      CountIt statementLambda = (int x) =>
      {
        int sum = 0;
        for (int i = 0; i < x; i++)
        {
          sum += i;
        }
        return sum;
      };
      #endregion
      Console.WriteLine(statementLambda(5));
    }
  }
}
