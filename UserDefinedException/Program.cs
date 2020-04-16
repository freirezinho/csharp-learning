using System;

namespace UserDefinedException
{
  class AgeNotAllowedException : ApplicationException
  {
    public AgeNotAllowedException(string s) : base(s)
    {

    }
  }
  class Program
  {
    public void AcceptAge()
    {
      int age;
      Console.WriteLine("Enter your age");
      age = Convert.ToInt32(Console.ReadLine());
      if (age < 20 || age > 40)
      {
        AgeNotAllowedException exp = new AgeNotAllowedException("Age between 20 and 40 is allowed");
        throw exp;
      }
      else
      {
        Console.WriteLine("Welcome");
      }
    }
    static void Main(string[] args)
    {
      Program p = new Program();
      try
      {
        p.AcceptAge();
      }
      catch (AgeNotAllowedException obj)
      {
        Console.WriteLine(obj.Message);
      }
    }
  }
}
