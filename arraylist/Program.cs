using System;
using System.Collections;

namespace arraylist
{
  class Program
  {
    static void Main(string[] args)
    {
      ArrayList arr = new ArrayList();
      arr.Add(23);
      arr.Add("string");
      for (int i = 0; i < arr.Count; i++)
      {
        Console.WriteLine("{0}", arr[i]);
      }
      arr.TrimToSize();
    }
  }
}
