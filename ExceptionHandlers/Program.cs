using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExceptionHandlers
{
  class Program
  {
    static void Main(string[] args)
    {
      StreamReader streamReader = null;

      try
      {
        using (StreamReader streamReader = new StreamReader(@"file.txt"))
        {
          string content = streamReader.ReadToEnd();

        }
      }
      catch (System.Exception e)
      {

        Console.WriteLine(e.Message);
      }
    }
  }
  public class Division
  {
    public int Divide(int numerator, int denominator)
    {
      return numerator / denominator;
    }
  }
}
