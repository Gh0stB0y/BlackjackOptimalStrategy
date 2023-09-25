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
        public static void GetADealerCard()
        {
            if (TableModel.CsmEnabled)
            {
                Random randomCard = new Random();
                TableModel.DealerCards.Add(randomCard.Next(0, 52));
                TableModel.DealerScore += CardsModel.CardValues[TableModel.DealerCards.Last()];
            }
            else
            {
                TableModel.DealerCards.Add(TableModel.ShoeCards.Pop());
                TableModel.DealerScore += CardsModel.CardValues[TableModel.DealerCards.Last()];
                TableModel.CardsPlayed++;
            }

            if (CardsModel.CardValues[TableModel.DealerCards.Last()] == 11)
                TableModel.DealerAceCount++;

            if (TableModel.DealerScore > 21 && TableModel.DealerAceCount > 0)
            {
                TableModel.DealerScore -= 10;
                TableModel.DealerAceCount--;
            }
        }
    }
}
