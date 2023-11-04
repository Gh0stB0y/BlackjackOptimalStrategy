using BlackjackStrategy.DataContainers;
using BlackjackStrategy.GameModels;
using BlackjackStrategy.Methods.Commands.Generations.Iterations.PlayGame.AuxiliaryMethods.GenerateResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackStrategy.Methods.Commands
{
    public static partial class Commands
    {
        public static void PlayerBlackjack(int seatId)
        {

            if (TableModel.DealerCards[0] <= 31)
            {
                if (TableModel.Seats[seatId].WinningStreak == 0)
                    CompareStreaks.CompareLoseStreak(TableModel.Seats[seatId].LosingStreak);
                TableModel.Seats[seatId].SeatActive = false;
                TableModel.Seats[seatId].WinningStreak++;
                TableModel.Seats[seatId].LosingStreak = 0;
                if (TableModel.Seats[seatId].SeatTakenByPlayer)
                {
                    PlayerModel.Bankroll += TableModel.Seats[seatId].Bet * 2.5;
                    Statistics.Wins++;
                }
            }
        }
    }
}
