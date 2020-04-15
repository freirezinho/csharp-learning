using System;

namespace OOP1
{
  class Employee
  {
    string name, email;
    int phoneno;

    public void Assign(string n, string e, int p)
    {
      name = n;
      email = e;
      phoneno = p;
    }

    public void Print()
    {
      Console.WriteLine("{0}", name);
      Console.WriteLine("{0}", email);
      Console.WriteLine("{0}", phoneno);
    }
    public Employee(string n = "", string e = "", int p = 0)
    {
      name = n;
      email = e;
      phoneno = p;
    }
    static void Main(string[] args)
    {
      Employee mario = new Employee("Mario", "mario@nintendo.com", 1800555555);
      mario.Print();
      Employee luigi = new Employee();
      luigi.Print();
    }
  }
}
