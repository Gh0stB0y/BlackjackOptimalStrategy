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
        public static void FirstDecision(int seatId)
        {
            if (TableModel.Seats[seatId].Score == 21) PlayerBlackjack(seatId);
            else
            {
                int decision = ManageFirstTwoCards(seatId);
                if (decision == 6 && !TableModel.Surrender) decision = 1;
                switch (decision)
                {
                    case 1:
                        Hit(seatId);
                        break;
                    case 2:
                        Stand(seatId);
                        break;
                    case 3:
                    case 4:
                        DoubleDown(seatId);
                        break;
                    case 5:
                        SplitCards(seatId);
                        break;
                    case 6:
                        SurrenderGame(seatId);
                        break;
                    default: throw new Exception("First decision issue");
                }
            }
        }
    }
}
