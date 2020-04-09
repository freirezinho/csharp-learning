using System;

class Program
{
  static void Main(string[] args)
  {
    char ch;
    string vowel_message;
    Console.WriteLine("Enter a character (a-z):");
    ch = Char.ToLower(Convert.ToChar(Console.ReadLine()));
    vowel_message = "Vowel.";
    switch (ch)
    {
      case 'a':
      case 'e':
      case 'i':
      case 'o':
      case 'u':
        Console.WriteLine(vowel_message);
        break;
      default:
        if (Char.IsDigit(ch))
        {
          Console.WriteLine("That's a number...");
        }
        else
        {
          Console.WriteLine("Consonant.");
        }
        // Console.WriteLine("Not a vowel.");
        break;
    }
  }
}
