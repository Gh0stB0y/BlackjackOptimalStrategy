using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackStrategy.GameModels
{
    public static class PlayerModel
    {
        public static List<int> SeatsTaken = new();

        public static List<int> BettingSystem=new();
        public static bool CountingCards { get; set; } = false;
        public static int Bankroll { get; set; } = 50; //in units, not dollars 
        public static long GamesPlayed { get; set; } = 10 ^ 8;
    }
}
