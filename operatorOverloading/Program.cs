using System;

namespace operatorOverloading
{
  class Program
  {
    static void Main(string[] args)
    {
      // Player Archer = new Player(2, 10, PlayerType.Archer);
      // Player Magician = new Player(4, 20, PlayerType.Magician);

      // Archer.Display(PlayerType.Archer);

      // Player HybridWarrior = Archer + Magician;
      // HybridWarrior.Display(PlayerType.Hybrid);
      // int newXP = HybridWarrior + 10;
      // Console.WriteLine("The new XP for Hybrid Warrior is = " + newXP);
      // Player Emperor = HybridWarrior + Magician;
      // if (HybridWarrior > Emperor)
      //   Console.WriteLine("HybridWarrior is stronger than Emperor");
      // else
      //   Console.WriteLine("Emperor is the strongest of them all!");
      // int x = Emperor;
      // Console.WriteLine("\nEmperor has an XP of " + x);
      Player Archer = new Player(2, 10, PlayerType.Archer, Inventory.Melee, Inventory.Range);
      Archer.Display(PlayerType.Archer);
      Archer[1] = Inventory.Lightning.ToString();
      Archer.Display(PlayerType.Archer);
      Console.WriteLine("\n" + Archer[2, 3]);
    }
  }
}
