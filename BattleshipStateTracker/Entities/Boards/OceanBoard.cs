using System;
using System.Collections.Generic;
using System.Text;
using BattleshipStateTracker.Enums;

namespace BattleshipStateTracker.Entities.Boards
{
    public class OceanBoard : Board
    {
        public OceanBoard()
        {
            BoardType = BoardType.OceanBoard;
            Cells = new List<Cell>();
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    Cells.Add(new Cell(x, y));
                }
            }
        }
    }
}
