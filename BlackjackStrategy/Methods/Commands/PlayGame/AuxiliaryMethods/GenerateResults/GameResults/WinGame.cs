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
        public static void WinGame(int seatId,double multiplier)
        {            
            TableModel.Seats[seatId].SeatActive = false;
            TableModel.Seats[seatId].WinningStreak++;
            if (TableModel.Seats[seatId].SeatTakenByPlayer)
            {
                PlayerModel.Bankroll += TableModel.Seats[seatId].Bet * multiplier;
                PlayerModel.Profit += TableModel.Seats[seatId].Bet * multiplier;
                Statistics.Wins++;
                Statistics.Profit += TableModel.Seats[seatId].Bet*(multiplier-1);
            }
            
        }
    }
}
