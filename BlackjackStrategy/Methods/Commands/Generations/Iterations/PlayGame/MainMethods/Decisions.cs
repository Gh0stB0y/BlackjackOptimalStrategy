using BlackjackStrategy.GameModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackStrategy.Methods.Commands
{
    public static partial class Commands
    {
        public static void Decisions()
        {
            int seatId = TableModel.Seats.Count - 1;
            do
            {
                
                if (TableModel.Seats[seatId].SeatActive)
                {
                    //Console.WriteLine("new seat:");
                    //Console.WriteLine("Bankroll" + PlayerModel.Bankroll);
                    FirstDecision(seatId);
                    //Console.WriteLine("Initial score "+TableModel.Seats[seatId].Score);
                    while ( TableModel.Seats[seatId].LastDecision == "Hit")
                    {
                        //Console.WriteLine("score in the loop: "+ TableModel.Seats[seatId].Score);
                        if (!HandBusted(seatId))
                        {
                            NextDecision(seatId);
                        }
                        else break;
                    }                    
                }
                seatId--;
            } while (seatId >= 0);
           
        }
        public static void Decisions(int seatId)
        {
            Queries.Queries.DisplayTableWithCards();
            FirstDecision(seatId);
            Queries.Queries.DisplayTableWithCards();
            NextDecision(seatId);
        }
    }
}
