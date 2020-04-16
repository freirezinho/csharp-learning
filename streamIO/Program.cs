using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace streamIO
{
  class Program
  {
    public void ReadData()
    {
      FileStream fs = new FileStream(@"test.txt", FileMode.Open, FileAccess.Read);
      StreamReader sr = new StreamReader(fs);
      sr.BaseStream.Seek(-8, SeekOrigin.End);
      string str = "";
      Console.WriteLine("Lendo arquivo...");
      while (str != null)
      {
        str = sr.ReadLine();
        Console.WriteLine(str);
      }
      sr.Close();
      fs.Close();
    }
    public void WriteData()
    {
      FileStream fs = new FileStream("test_c.txt", FileMode.Create, FileAccess.Write);
      StreamWriter sw = new StreamWriter(fs);
      Console.WriteLine("Escrevendo arquivo...");
      sw.Write("Testando write.");
      sw.WriteLine("\nPulando linha.");
      sw.Write("3a linha?");
      sw.Flush();
      sw.Close();
      fs.Close();
    }
    static void Main(string[] args)
    {
      Program p1 = new Program();
      p1.ReadData();
      p1.WriteData();

    }
  }
}
