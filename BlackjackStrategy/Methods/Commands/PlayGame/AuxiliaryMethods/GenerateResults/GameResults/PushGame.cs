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
        public static void PushGame(int seatId)
        {
            TableModel.Seats[seatId].SeatActive = false;
            if (TableModel.Seats[seatId].SeatTakenByPlayer)
            {
                PlayerModel.Bankroll += TableModel.Seats[seatId].Bet * 1;
                PlayerModel.Profit += TableModel.Seats[seatId].Bet * 1;
                Statistics.Pushes++;
            }
        }
    }
}
