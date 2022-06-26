using System;
using System.Collections.Generic;
using System.Text;
using BattleshipStateTracker.Enums;

namespace BattleshipStateTracker.Entities.Ships
{
    public class Battleship : Ship
    {
        public Battleship()
        {
            Name = "Battleship";
            BattleShipType = BattleShipType.Battleship;
            Holes = 4;
            //Hits = 0;
        }
    }
}
