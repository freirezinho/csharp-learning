using System;

namespace events
{
  public delegate void EventHandler();
  class Program
  {
    public static event EventHandler Print;
    static void Handler1()
    {
      Console.WriteLine("Handler 1");
    }
    static void Handler2()
    {
      Console.WriteLine("Handler 2");
    }
    static void Handler3()
    {
      Console.WriteLine("Handler 3");
    }
    static void Handler4()
    {
      Console.WriteLine("Handler 4");
    }
    static void Main(string[] args)
    {
      Print += new EventHandler(Handler1);
      Print += new EventHandler(Handler2);
      Print += new EventHandler(Handler3);
      Print += new EventHandler(Handler4);
      Print.Invoke();
    }
  }
}
