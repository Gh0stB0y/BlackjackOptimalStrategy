using BlackjackStrategy.GameModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackStrategy.DataContainers
{
    public static class Statistics
    {
        public static int Wins { get; set; } = 0;
        public static int Loses { get; set; } = 0;
        public static double Winratio { get; set; } = 0;
        public static double InitialBankroll { get; set; } = 0;
        public static double FinalBankroll { get; set; } = 0;
        public static double Profit { get; set; } = 0;
        public static int Fuckups { get; set; } = 0;
        public static int Pushes { get; set; }
        public static int BiggestWinStreak { get; set; } = 0;
        public static int BiggestLoseStreak { get; set; } = 0;

        public static List<double>ProfitFromIterations = new List<double>();

        public static void ClearStats()
        {
            Wins = 0; 
            Loses = 0;
            Winratio = 0; 
            InitialBankroll = PlayerModel.InitialBankroll;
            FinalBankroll = 0;
            Profit = 0;
            Fuckups = 0;
            BiggestWinStreak = 0;
            BiggestLoseStreak = 0;
            Pushes = 0;
            PlayerModel.NumberOfGamesPlayed = 0;
            PlayerModel.Busted = false;
        }
    }


}
