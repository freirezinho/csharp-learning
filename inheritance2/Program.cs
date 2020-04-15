using System;

namespace inheritance2
{
  class Animal
  {
    public Animal()
    {
      Console.WriteLine("cons of animal");
    }
    public Animal(int w)
    {
      Console.WriteLine("cons of animal with one param: {0}", w);
    }
    ~Animal()
    {
      Console.WriteLine("Desc of animal");
    }
  }
  class Cat : Animal
  {
    public Cat()
    {
      Console.WriteLine("cons of cat");
    }
    public Cat(int n) : base(n)
    {
      Console.WriteLine("cons of cat with one param: {0}", n);
    }
    ~Cat()
    {
      Console.WriteLine("desc of cat");
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      Cat obj = new Cat(45);
    }
  }
}
