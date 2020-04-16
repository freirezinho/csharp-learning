using System;
using System.Threading;

namespace multithread
{
  class Program
  {
    enum ThreadStates
    {
      Unstarted,
      Runnable,
      NonRunnable, // if Sleeping, Waiting or Blocked
      Dead
    }
    public void Display1()
    {
      Console.WriteLine("Display 1 started");
      Monitor.Enter(this);
      for (int i = 0; i < 30; i++)
      {
        Console.WriteLine("Display 1");
        Thread.Sleep(1000);
      }
      Monitor.Exit(this);
      Console.WriteLine("Display 1 ended.");
    }
    public void Display2()
    {
      Console.WriteLine("Display 2 started");
      Monitor.Enter(this);
      for (int i = 0; i < 30; i++)
      {
        Console.WriteLine("Display 2");
        Thread.Sleep(1000);
      }
      Monitor.Exit(this);
      Console.WriteLine("Display 2 ended.");
    }
    static void Main(string[] args)
    {
      Program p = new Program();
      ThreadStart ts1 = new ThreadStart(p.Display1);
      Thread th1 = new Thread(ts1);
      ThreadStart ts2 = new ThreadStart(p.Display2);
      Thread th2 = new Thread(ts2);
      th1.Priority = ThreadPriority.Lowest;
      th2.Priority = ThreadPriority.Highest;
      th1.Start();
      th2.Start();

      Thread.Sleep(2000);
      //   Não suportado em .NET Core
      //   th1.Abort();
      //   th1.Suspend();
      //   th1.Resume();
    }
  }
}
