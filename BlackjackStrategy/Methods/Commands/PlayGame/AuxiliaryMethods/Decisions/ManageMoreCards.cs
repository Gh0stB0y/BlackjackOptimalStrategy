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
        public static int ManageMoreCards(int seatId)
        {
            int DealerCardVal = CardsModel.CardValues[TableModel.DealerCards[0]];

            if (TableModel.Seats[seatId].AceCount > 0 )
            {
                //TableModel.Seats[seatId].AceCount++;
                int row = TableModel.Seats[seatId].Score - 13;
                return CardDecision.SoftChart[row][DealerCardVal - 2];
            }
            else
            {
                int row = TableModel.Seats[seatId].Score - 5;
                return CardDecision.HardChart[row][DealerCardVal - 2];
            }
        }


    }
}
