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
        public static void GenerateResults() 
        {
            int seatId = TableModel.Seats.Count - 1;
            do
            {
                if (TableModel.Seats[seatId].SeatActive)
                {
                    int whoWins;
                    if (TableModel.DealerBusted)
                        whoWins = 2;
                    else
                        whoWins = CompareValues(seatId);
                    switch (whoWins)
                    {
                        case 0:
                            LoseGame(seatId, 1);
                            //Console.WriteLine("Lose");
                            break;
                        case 1:
                            PushGame(seatId);
                            //Console.WriteLine("Push");
                            break;
                        case 2:
                            if (CardsModel.CardValues[TableModel.Seats[seatId].Cards[0]] +
                                    CardsModel.CardValues[TableModel.Seats[seatId].Cards[1]] == 21)
                            {
                                WinGame(seatId, 2.5);
                                //Console.WriteLine("Blackjack");
                            }
                            else
                            {
                                WinGame(seatId,2);
                                //Console.WriteLine("Win");
                            }
                            break;
                    }
                    TableModel.Seats[seatId].SeatActive = false;
                    //Console.WriteLine(PlayerModel.Bankroll);
                }
                seatId--;
            } while (seatId >= 0);
            /*Console.WriteLine(PlayerModel.Bankroll);
            Console.ReadKey();*/
        }
    }
}
