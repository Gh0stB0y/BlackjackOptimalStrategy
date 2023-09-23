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
        public static void GetACard(int seatId)
        {
            if (TableModel.CsmEnabled)
            {
                Random randomCard = new Random();
                TableModel.Seats[seatId].Cards.Add(randomCard.Next(0, 52));
                TableModel.Seats[seatId].Score += CardsModel.CardValues[TableModel.Seats[seatId].Cards.Last()];
            }
            else
            {
                TableModel.Seats[seatId].Cards.Add(TableModel.ShoeCards.Pop());
                TableModel.Seats[seatId].Score += CardsModel.CardValues[TableModel.Seats[seatId].Cards.Last()];
                TableModel.CardsPlayed++;
            }
        }
    }
}
