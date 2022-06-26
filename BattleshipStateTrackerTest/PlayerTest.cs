using System;
using Xunit;
using BattleshipStateTracker.Entities;
using BattleshipStateTracker.Enums;
using BattleshipStateTracker.Extensions;
using BattleshipStateTracker;
using BattleshipStateTracker.Entities.Boards;

namespace BattleshipStateTrackerTest
{
    public class PlayerTest
    {
        [Fact]
        public void CreatePlayer()
        {
            string name = "Nithu";
            Player player = new Player(name);
            Assert.Equal(player.Name, name);
        }

        [Theory]
        [InlineData("Nithu1", 5)]
        [InlineData("Nithu2", 5)]
        public void ValidatePlayerFleet(string name, int shipCount)
        {
            Player player = new Player(name);
            Assert.Equal(player.Name, name);
            Assert.Equal(player.Fleet.Count, shipCount);
        }

        [Theory]
        [InlineData("Nithu1", ShotResult.Hit)]
        [InlineData("Nithu1", ShotResult.Miss)]
        [InlineData("Nithu2", ShotResult.Hit)]
        [InlineData("Nithu2", ShotResult.Miss)]
        public void PlaceFleet_validateFireShot(string name, ShotResult shotResult)
        {
            Player player = new Player(name);
            player.AddShips();
            //since the ships are placed randomly they will never be at same place
            Coordinates coords = new Coordinates(4, 7);
            Assert.Equal(player.ProcessShot(coords), shotResult);
        }
    }
}
