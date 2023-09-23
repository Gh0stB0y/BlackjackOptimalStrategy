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
        public static void SplitCards(int seatId)
        {
            int newSeatId = seatId + 1;
            if (TableModel.Seats[seatId].SeatTakenByPlayer)
            {
                PlayerModel.Bankroll -= TableModel.Seats[seatId].Bet;
                PlayerModel.Profit -= TableModel.Seats[seatId].Bet;
            }
            SeatModel additionalSeat = new(newSeatId)
            {
                SeatTaken = true,
                SeatTakenByPlayer = TableModel.Seats[seatId].SeatTakenByPlayer,
                SeatActive = true,
                Bet = TableModel.Seats[seatId].Bet,
                AdditionalSeat = true
            };

            for (int i = newSeatId; i < TableModel.Seats.Count;i++) TableModel.Seats[seatId].SeatId++;
            TableModel.Seats.Insert(newSeatId, additionalSeat);

            TableModel.Seats[newSeatId].Cards.Add(TableModel.Seats[seatId].Cards[1]);
            TableModel.Seats[seatId].Cards.RemoveAt(1);

            if (TableModel.Seats[seatId].Cards[0] >= 48) // spliting aces
            {
                GetACard(seatId);
                GetACard(newSeatId);
            }
            else //spliting anything except aces
            {
                GetACard(newSeatId);
                Decisions(newSeatId);
                GetACard(seatId);
                Decisions(seatId);
            }
        }
        
    }
}
