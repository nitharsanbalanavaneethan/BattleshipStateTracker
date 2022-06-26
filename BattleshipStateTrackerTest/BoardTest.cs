using System;
using Xunit;
using BattleshipStateTracker.Entities;
using BattleshipStateTracker.Enums;
using BattleshipStateTracker.Extensions;
using BattleshipStateTracker;
using BattleshipStateTracker.Entities.Boards;

namespace BattleshipStateTrackerTest
{
    public class BoardTest
    {
        [Fact]
        public void CreateOceanBoard_validateBoardTypeCreated()
        {
            BoardType ocean = BoardType.OceanBoard;
            OceanBoard oceanBoard = new OceanBoard();
            Assert.Equal(oceanBoard.BoardType, ocean);
        }

        [Fact]
        public void CreateTargetBoard_validateBoardTypeCreated()
        {
            BoardType target = BoardType.TargetBoard;
            TargetBoard targetBoard = new TargetBoard();
            Assert.Equal(targetBoard.BoardType, target);
        }

        
    }
}
