﻿using BlackjackStrategy.GameModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackStrategy.Methods.Commands
{
    public static partial class Commands
    {
        public static void DealersTurn()
        {
            if (!TableModel.SecondDealerCard)
            {
                GetADealerCard();
                Queries.Queries.DisplayTableWithCards();
            }
            DealerDecisions();
        }
    }
}
