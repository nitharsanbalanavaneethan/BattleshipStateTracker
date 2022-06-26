using System;
using System.Collections.Generic;
using System.Text;
using BattleshipStateTracker.Enums;
using System.Linq;

namespace BattleshipStateTracker.Entities.Boards
{
    public class TargetBoard : Board
    {
        public TargetBoard()
        {
            BoardType = BoardType.TargetBoard;
            Cells = new List<Cell>();

            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    Cells.Add(new Cell(i, j));
                }
            }
        }

        public List<Coordinates> GetRandomCells()
        {
            return Cells.Where(x => x.BattleShipType == BattleShipType.None && x.isAvailable).Select(x => x.Coordinates).ToList();
        }
    }
}
