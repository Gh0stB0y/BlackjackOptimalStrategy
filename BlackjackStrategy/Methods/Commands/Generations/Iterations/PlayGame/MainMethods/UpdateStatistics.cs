using BlackjackStrategy.DataContainers;
using BlackjackStrategy.GameModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackStrategy.Methods.Commands
{
    public static partial class Commands
    {
        public static void UpdateStatistics()
        {
            Statistics.FinalBankroll=PlayerModel.Bankroll;
            Statistics.Profit = Statistics.FinalBankroll - Statistics.InitialBankroll;
            Statistics.Winratio = (double)Statistics.Wins/(double)(Statistics.Wins + Statistics.Loses);
            /*Console.WriteLine($"Wins: {Statistics.Wins}, Loses: {Statistics.Loses}, Pushes: {Statistics.Pushes}, Win ratio: {Statistics.Winratio}");
            Console.WriteLine($"Biggest Winning Streak: {Statistics.BiggestWinStreak}, Biggest Losing Streak: {Statistics.BiggestLoseStreak}");
            Console.WriteLine($"Final Bankroll: {PlayerModel.Bankroll}, Profit:{Statistics.Profit}, Games played: {PlayerModel.NumberOfGamesPlayed}");
            Console.WriteLine();*/
        }
    }
}
