using System;

namespace ExtensionMethods
{
  class Program
  {

    static void Main(string[] args)
    {
      bool[] boolTable = new bool[5];
      boolTable.PopulateTable(false);
      foreach (var item in boolTable)
      {
        Console.WriteLine(item);
      }
      string value = "hello world";
      value = value.UppercaseFirstLetter();
      Console.WriteLine(value);

    }
  }
  public static class ExtensionMethods
  {
    public static void PopulateTable<T>(this T[] array, T value)
    {
      if (array.Length > 0)
      {
        for (int i = 0; i < array.Length; i++)
        {
          array[i] = value;
        }
      }

    }
    public static string UppercaseFirstLetter(this string value)
    {
      if (value.Length > 0)
      {
        char[] array = value.ToCharArray();
        array[0] = Char.ToUpper(array[0]);
        return new string(array);
      }
      return value;

    }
  }
}
