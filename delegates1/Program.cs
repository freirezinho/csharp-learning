using System;

namespace delegates1
{
  //   public delegate int SampleDelegate(int x, int y);
  //   public delegate void MulticastDelegate(int x, int y);
  //   public class NumberClass
  //   {
  //     public static int Add(int x, int y)
  //     {
  //       return (x + y);
  //     }
  //     public static int Multiply(int x, int y)
  //     {
  //       return (x * y);
  //     }
  //   }
  //   public class Foo
  //   {
  //     public static void Add(int x, int y)
  //     {
  //       Console.WriteLine("Add Method");
  //       Console.WriteLine("{0} + {1} = " + (x + y), x, y);

  //     }
  //     public static void Multiply(int x, int y)
  //     {
  //       Console.WriteLine("Multiply Method");

  //       Console.WriteLine("{0} * {1} = " + x * y, x, y);
  //     }
  //   }
  public delegate Employee EmployeeDelegate();

  class Program
  {
    public static Employee GetEmployee()
    {
      return new Employee();
    }
    public static SalesEmployee GetSalesEmployee()
    {
      return new SalesEmployee();

    }
    static void Main(string[] args)
    {
      //   SampleDelegate del1 = new SampleDelegate(NumberClass.Add);
      //   int addResult = del1(5, 5);
      //   Console.WriteLine("5 + 5 = " + addResult);
      //   SampleDelegate del2 = new SampleDelegate(NumberClass.Multiply);
      //   int product = del2(5, 5);
      //   Console.WriteLine("5 * 5 = " + product);

      //   MulticastDelegate del3 = new MulticastDelegate(Foo.Add);
      //   del3 += new MulticastDelegate(Foo.Multiply);
      //   Console.WriteLine("... calling Add() and Multiply() methods.\n");
      //   del3(5, 5);
      //   del3 -= new MulticastDelegate(Foo.Add);
      //   Console.WriteLine("\nAdd() method unsubscribed\n");
      //   del3(5, 5);
      EmployeeDelegate empDel = new EmployeeDelegate(GetEmployee);
      Employee employee_1 = empDel();
      EmployeeDelegate salesEmpDel = new EmployeeDelegate(GetSalesEmployee);
      SalesEmployee employee_2 = (SalesEmployee)salesEmpDel();
    }
  }
  public class Employee
  {
    protected string firstName;
    protected string lastName;
    protected int age;

    public Employee() { }
    public Employee(string fName, string lName, int _age)
    {
      firstName = fName;
      lastName = lName;
      age = _age;
    }
  }
  public class SalesEmployee : Employee
  {
    protected int salesNumber;
    public SalesEmployee() { }
    public SalesEmployee(string fName, string lName, int _age, int sNumber) : base(fName, lName, _age)
    {
      salesNumber = sNumber;
    }
  }
}
