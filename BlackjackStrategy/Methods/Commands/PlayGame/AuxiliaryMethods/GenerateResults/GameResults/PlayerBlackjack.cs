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
        public static void PlayerBlackjack(int seatId)
        {

            if (TableModel.DealerCards[0] <= 31)
            {
                TableModel.Seats[seatId].SeatActive = false;
                TableModel.Seats[seatId].WinningStreak++;
                if (TableModel.Seats[seatId].SeatTakenByPlayer)
                {
                    PlayerModel.Bankroll += TableModel.Seats[seatId].Bet * 2.5;
                    PlayerModel.Profit += TableModel.Seats[seatId].Bet * 2.5;
                    Statistics.Wins++;
                    PlayerModel.Profit += TableModel.Seats[seatId].Bet * 1.5;
                }
            }
        }
    }
}
