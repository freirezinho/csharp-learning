using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace references_values
{
  class Program
  {
    static void Main(string[] args)
    {
      Player Archer = new Player();
      Archer.skillSets = 2;
      Archer.xp = 10;
      Display(Archer);
      Change(Archer);
      Display(Archer);
    }
    static void Display(Player player)
    {
      Console.WriteLine("Archer now has " + player.skillSets + " skills.");
      Console.WriteLine("He also has a renewd XP of " + player.xp + ".");
    }
    static void Change(Player player)
    {
      player.skillSets = 4;
      player.xp = 20;
    }
  }
}
