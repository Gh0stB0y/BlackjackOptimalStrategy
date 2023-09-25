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
        public static void DefineAWinner()
        {
            int seatId = TableModel.Seats.Count - 1;
            do
            {
                if (TableModel.Seats[seatId].SeatActive)
                {
                    int whoWins;
                    if (!TableModel.DealerBusted)
                        whoWins=CompareValues(seatId);
                    else
                        whoWins = 2;
                    
                    switch (whoWins)
                    {
                        case 0:
                            LoseGame(seatId, 1);
                            break;
                        case 1:
                            PushGame(seatId);
                            break;
                        case 2:
                            if (CardsModel.CardValues[TableModel.Seats[seatId].Cards[0]] +
                                    CardsModel.CardValues[TableModel.Seats[seatId].Cards[1]] == 21)
                                PlayerBlackjack(seatId);
                            else
                                WinGame(seatId);
                            break;
                    }
                }
                seatId--;
            } while (seatId >= 0);
        }
    }
}
