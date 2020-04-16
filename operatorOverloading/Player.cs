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
  class Player
  {
    private int skillSets;
    private int xp;
    private PlayerType playerType;

    public Player(int _skillSets, int _xp, PlayerType _playerType)
    {
      skillSets = _skillSets;
      xp = _xp;
      playerType = _playerType;
    }
    public void Display(PlayerType playerType)
    {
      Console.WriteLine("\n" + playerType.ToString() + " has " + skillSets + " skills with an xp of " + xp);
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
  }
}

