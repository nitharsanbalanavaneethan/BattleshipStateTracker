using System;
using System.Collections.Generic;
using System.Text;
using BattleshipStateTracker.Enums;

namespace BattleshipStateTracker.Entities.Boards
{
    public abstract class Board
    {
        public BoardType BoardType { get; set; }

        public List<Cell> Cells { get; set; }

    }
}
