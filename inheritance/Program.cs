using System;

namespace inheritance
{
  class Employee
  {
    protected int eid;
    protected string ename;
  }
  class PartTime : Employee
  {
    public int noh;
    static void Main(string[] args)
    {
      PartTime p = new PartTime();
      p.noh = 5;
      p.eid = 0;
      p.ename = "John";

    }
  }
  class FullTime : Employee
  {
    public int shift;
  }
  class Program
  {

  }
}
