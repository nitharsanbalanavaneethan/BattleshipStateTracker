using System;
using System.Collections.Generic;
using System.Text;
using BattleshipStateTracker.Enums;

namespace BattleshipStateTracker.Entities.Ships
{
    public class Carrier : Ship
    {
        public Carrier()
        {
            Name = "Carrier";
            BattleShipType = BattleShipType.Carrier;
            Holes = 5;
            //Hits = 0;
        }
    }
}
