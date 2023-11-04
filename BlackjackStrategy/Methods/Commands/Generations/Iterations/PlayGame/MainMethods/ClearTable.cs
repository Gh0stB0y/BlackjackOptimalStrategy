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
        public static void ClearTable()
        {
            int seatId = TableModel.Seats.Count - 1;
            do
            {
                if (TableModel.Seats[seatId].AdditionalSeat)
                    TableModel.Seats.RemoveAt(seatId);
                seatId--;
            } while(seatId >= 0);

            foreach (var seat in TableModel.Seats)
            {
                seat.Cards.Clear();
                seat.Score = 0;
                seat.AceCount = 0;
                seat.LastDecision = string.Empty;
                if(seat.SeatTaken)seat.SeatActive = true;
            }
            TableModel.DealerCards.Clear();
            TableModel.DealerAceCount = 0;
            TableModel.DealerScore = 0;
            TableModel.DealerBusted = false;
            PlayerModel.NumberOfGamesPlayed++;
        }
    }
}
