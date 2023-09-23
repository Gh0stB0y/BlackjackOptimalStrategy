using BlackjackStrategy.GameModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackjackStrategy.Methods.Commands;

namespace BlackjackStrategy.Testing
{
    public static partial class Testing
    {
        public static void InitialCardsTest()
        {
            foreach(var seat in TableModel.Seats)
            {
                if (seat.SeatActive)
                {
                    seat.Cards = new List<int>() { 15, 19 };
                    seat.Score = CardsModel.CardValues[seat.Cards[0]] + CardsModel.CardValues[seat.Cards[1]];
                    
                }
                    
            }
            Commands.GetADealerCard();
        }
    }
}
