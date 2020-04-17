using System;

namespace operatorOverloading
{
  enum PlayerType
  {
    Archer,
    Magician,
    Grunt,
    Knight,
    Emperor,
    Hybrid
  }
  enum Inventory
  {
    Melee,
    Range,
    SelfHeal,
    ReviveDead,
    Teleport,
    Berserk,
    Lightning,
    Poison,
    SmokeCloud
  }
  class Player
  {
    private int skillSets;
    private int xp;
    private PlayerType playerType;
    private string[] inventoryTable;

    public Player(int _skillSets, int _xp, PlayerType _playerType, params Inventory[] inventories)
    {
      skillSets = _skillSets;
      xp = _xp;
      playerType = _playerType;
      inventoryTable = new string[skillSets];
      FillInventory(inventories);
    }
    private void FillInventory(Inventory[] inventories)
    {
      for (int i = 0; i < inventoryTable.Length; i++)
      {
        inventoryTable[i] = inventories[i].ToString();
      }
    }
    public void Display(PlayerType playerType)
    {
      Console.WriteLine("\n" + playerType.ToString() + " has " + skillSets + " skills with an xp of " + xp);
      Console.WriteLine("\nThe " + playerType.ToString() + "'s skills are : ");
      for (int i = 0; i < inventoryTable.Length; i++)
      {
        Console.WriteLine(inventoryTable[i]);
      }
    }
    public static Player operator +(Player player1, Player player2)
    {
      return new Player(player1.skillSets + player2.skillSets, player1.xp + player2.xp, PlayerType.Hybrid);
    }
    public static int operator +(Player player1, int xp)
    {
      return player1.xp + xp;
    }
    public static bool operator >(Player player1, Player player2)
    {
      if (player1.skillSets > player2.skillSets && player1.xp > player2.xp)
        return true;

      return false;
    }
    public static bool operator <(Player player1, Player player2)
    {
      if (player1.skillSets < player2.skillSets && player1.xp < player2.xp)
        return true;

      return false;
    }
    public static implicit operator int(Player player)
    {
      return player.xp;
    }
    public string this[int index]
    {
      get
      {
        if (index >= 0 && index < inventoryTable.Length)
        {
          return inventoryTable[index];
        }
        else
        {
          return "Inventory doesn't exist for " + index;
        }
      }
      set
      {
        if (index > 0 && index < inventoryTable.Length)
        {
          inventoryTable[index] = value;
        }
        else
        {
          Console.WriteLine("\nInventory cannot be set at " + index);
        }
      }
    }
    public string this[int index, int index2]
    {
      get
      {
        return (index + index2).ToString();
      }
    }
  }
}

