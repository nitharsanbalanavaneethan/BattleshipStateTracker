using System;
using System.Collections.Generic;
using System.Text;
using BattleshipStateTracker.Enums;

namespace BattleshipStateTracker.Entities.Ships
{
    public class Submarine : Ship
    {
        public Submarine()
        {
            Name = "Submarine";
            BattleShipType = BattleShipType.Submarine;
            Holes = 3;
            //Hits = 0;
        }
    }
}
