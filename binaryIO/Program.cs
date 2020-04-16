using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace binaryIO
{
  class Program
  {
    public void WriteData()
    {
      FileStream fs = new FileStream(@"binarydata.dat", FileMode.Create, FileAccess.Write);
      BinaryWriter bw = new BinaryWriter(fs);
      int num = 45;
      double d = 67.34;
      bool b = true;
      bw.Write(num);
      bw.Write(d);
      bw.Write(b);
      bw.Flush();
      bw.Close();
      fs.Close();
    }
    public void ReadData()
    {
      FileStream fs = new FileStream(@"binarydata.dat", FileMode.Open, FileAccess.Read);
      BinaryReader br = new BinaryReader(fs);
      int n = br.ReadInt32();
      double db = br.ReadDouble();
      bool bl = br.ReadBoolean();
      Console.WriteLine("{0} {1} {2}", n, db, bl);
      br.Close();
      fs.Close();

    }
    static void Main(string[] args)
    {
      Program p = new Program();
      p.WriteData();
      p.ReadData();
    }
  }
}
