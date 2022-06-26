using System;
using System.Collections.Generic;
using System.Text;
using BattleshipStateTracker.Enums;

namespace BattleshipStateTracker.Entities.Ships
{
    public class Cruiser : Ship
    {
        public Cruiser()
        {
            Name = "Cruiser";
            BattleShipType = BattleShipType.Cruiser;
            Holes = 3;
            //Hits = 0;
        }
    }
}
