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
        public static void DoubleDown(int seatId)
        {
            PlayerModel.Bankroll -= TableModel.Seats[seatId].Bet;
            TableModel.Seats[seatId].Bet *= 2;
            GetACard(seatId);

            TableModel.Seats[seatId].LastDecision = "Double";
        }
    }
}
