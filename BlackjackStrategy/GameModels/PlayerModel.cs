﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackStrategy.GameModels
{
    public static class PlayerModel
    {
        public static List<int> SeatsTaken = new();

        public static List<int> BettingSystem = new();
        public static bool CountingCards { get; set; } = false;
        public static double Bankroll { get; set; } = 50; //in units, not dollars 
        public static double InitialBankroll { get; set; } = 50;
        public static long MaxGamesPlayed { get; set; } = 10 ^ 8;
        public static long NumberOfGamesPlayed { get; set; } = 0;
        public static bool Busted { get; set; } = false;
    }
}
