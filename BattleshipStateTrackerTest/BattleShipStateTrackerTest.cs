using System;
using Xunit;
using BattleshipStateTracker.Entities;
using BattleshipStateTracker.Enums;
using BattleshipStateTracker.Extensions;
using BattleshipStateTracker;
using BattleshipStateTracker.Entities.Boards;

namespace BattleshipStateTrackerTest
{
    public class BattleShipStateTrackerTest
    {
        BattleshipStateTracker.BattleshipGame game = new BattleshipStateTracker.BattleshipGame();

        [Fact]
        public void CheckPlayers()
        {
            string playerName = "Player One Name";
            Assert.Equal(game.firstPlayer.Name, playerName);
        }

        [Fact]
        public void CheckFleetCount()
        {
            int count = 5;
            Assert.Equal(game.firstPlayer.Fleet.Count, count);
        }

        [Fact]
        public void ValidateBoardCells()
        {
            int cellCount = 100;
            Assert.Equal(game.firstPlayer.OceanBoard.Cells.Count, cellCount);
            Assert.Equal(game.firstPlayer.TargetBoard.Cells.Count, cellCount);
        }
         
    }
}
