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
                    Queries.Queries.DisplayTableWithCards();
                    FirstDecision(seatId);
                    Queries.Queries.DisplayTableWithCards();
                    NextDecision(seatId);
                }
                seatId--;
            } while (seatId >= 0);
            
        }
        public static void Decisions(int seatId)
        {
            FirstDecision(seatId);
            Queries.Queries.DisplayTableWithCards();
            NextDecision(seatId);
        }
    }
}
