using System;
using System.Collections.Generic;
using System.Text;
using BattleshipStateTracker.Enums;

namespace BattleshipStateTracker.Entities.Ships
{
    public class Destroyer : Ship
    {
        public Destroyer()
        {
            Name = "Destroyer";
            BattleShipType = BattleShipType.Destroyer;
            Holes = 2;
            //Hits = 0;
        }
    }
}
