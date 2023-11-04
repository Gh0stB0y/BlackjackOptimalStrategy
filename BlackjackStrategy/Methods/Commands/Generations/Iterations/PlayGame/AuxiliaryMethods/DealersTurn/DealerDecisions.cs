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
        public static void DealerDecisions()
        {
            while (TableModel.DealerScore <= 17)
            {
                if(TableModel.DealerScore == 17)
                {
                    if(TableModel.DealerAceCount >0 && !TableModel.StandOnSoft17)
                    {
                        DealerHit();
                        Queries.Queries.DisplayTableWithCards();
                    }
                    else
                    {
                        break;
                    }
                }
                else //16 or less
                {
                    DealerHit();
                    Queries.Queries.DisplayTableWithCards();
                }
            }
            if (TableModel.DealerScore > 21)
                TableModel.DealerBusted = true;
            else
                TableModel.DealerBusted = false;
        }

    }
}
