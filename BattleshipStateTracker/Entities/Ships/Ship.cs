using System;
using System.Collections.Generic;
using System.Text;
using BattleshipStateTracker.Enums;
using BattleshipStateTracker.Entities.Boards;

namespace BattleshipStateTracker.Entities.Ships
{
    public abstract class Ship
    {
        public string Name{ get; set; }
        public int Holes { get; set; }
        public int Hits { get; set; }

        public BattleShipType BattleShipType { get; set; }

        public bool IsSunk
        { 
            get
            {
                return Hits >= Holes;
            }
        
        }

        public int Miss
        {
            get
            {
                return Hits;
            }

        }

        public List<Coordinates> ShipCoordinates { get; set; }
    }
}
