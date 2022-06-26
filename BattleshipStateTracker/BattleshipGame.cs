using System;
using System.Collections.Generic;
using System.Text;

namespace BattleshipStateTracker
{
    public class BattleshipGame
    {
        public Player firstPlayer { get; set; }
        public Player secondPlayer { get; set; }


        public BattleshipGame( )
        {
            //Add 1nd Player
            firstPlayer = new Player("Player One Name");
            firstPlayer.AddShips();

            //Add 2nd Player
            secondPlayer = new Player("Player Two Name");
        }

        public void PlayRound()
        {
            //1st Player fires a shot and validates, is that shot is hit/miss
            var coordinates = secondPlayer.FireShot();
            var result = firstPlayer.ProcessShot(coordinates);

        }

    }

    
}
