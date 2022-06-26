using System;
using System.Collections.Generic;
using System.Text;
using BattleshipStateTracker.Enums;

namespace BattleshipStateTracker.Entities.Boards
{
    public class Cell
    {
        public BattleShipType BattleShipType { get; set; }
        
        public ShotResult ShotResult { get; set; }

        public Coordinates Coordinates { get; set; }

        public Cell(int row, int column)
        {
            Coordinates = new Coordinates(row, column);
            BattleShipType = BattleShipType.None;
        }

        public bool IsOccupied
        {
            get
            {
                return BattleShipType != BattleShipType.None;
            }
        }

        public bool isAvailable
        {
            get
            {
                return (Coordinates.Row % 2 == 0 && Coordinates.Column % 2 == 0)
                    || (Coordinates.Row % 2 == 1 && Coordinates.Column % 2 == 1);
            }
        }



    }
}
