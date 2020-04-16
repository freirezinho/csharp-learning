using System;
using System.IO;

namespace directoryInfo
{
  class Program
  {
    static void Main(string[] args)
    {
      DirectoryInfo dir = new DirectoryInfo("./");
      DirectoryInfo[] dirarr = dir.GetDirectories();
      FileInfo[] arr = dir.GetFiles();
      Console.WriteLine("-----------DIRECTORIES----------------------");
      foreach (DirectoryInfo directory in dirarr)
      {
        Console.WriteLine("{0}", directory.FullName);
      }
      Console.WriteLine("-----------FILES----------------------");
      foreach (FileInfo file in arr)
      {
        Console.WriteLine("{0}----{1}----{2}", file.FullName, file.Length, file.Extension);
      }
    }
  }
}
