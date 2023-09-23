using BlackjackStrategy.DecisionMaking;
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
        public static int ManageFirstTwoCards(int seatId)
        {
            int DealerCardVal = CardsModel.CardValues[TableModel.DealerCards[0]];
            //CheckPairs
            if (CardsModel.CardValues[TableModel.Seats[seatId].Cards[0]] == 
                    CardsModel.CardValues[TableModel.Seats[seatId].Cards[1]])
            {
                int row = (TableModel.Seats[seatId].Score / 2)-2;
                return CardDecision.PairsChart[row][DealerCardVal-2];
            }
            //CheckAce
            else if (CardsModel.CardValues[TableModel.Seats[seatId].Cards[0]] == 11||
                    CardsModel.CardValues[TableModel.Seats[seatId].Cards[1]] == 11)
            {
                TableModel.Seats[seatId].AceCount++;
                int row = TableModel.Seats[seatId].Score - 13;
                return CardDecision.SoftChart[row][DealerCardVal - 2];
            }
            //No Ace no Pair
            else 
            {
                int row = TableModel.Seats[seatId].Score - 5;
                return CardDecision.HardChart[row][DealerCardVal - 2];
            }

        }
    }
}
