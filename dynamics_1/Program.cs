using System;
using System.Reflection;

namespace dynamics_1
{
  class Program
  {
    static void Main(string[] args)
    {
      object obj = "Foo";
      // obj.GetHashCode();

      // using Reflection
      //   MethodInfo methodInfo = obj.GetType().GetMethod("GetHashCode");
      //   methodInfo.Invoke();

      // with reflection
      //   object excelObject = "SomeExcelObject";
      //   excelObject.Optimize();
      // using dynamics
      //   dynamic excelObject = "SomeExcelObject";
      //   excelObject.Optimize();

      // it will not change type after being initialized
      //   dynamic name = "Foo";
      //   name++;

      // se var recebe pelo menos uma variável dinâmica, ela se torna dinâmica tbm

      dynamic x = 10;
      int y = 20;
      var z = x + y;
      Console.WriteLine(z);
    }
  }
}
