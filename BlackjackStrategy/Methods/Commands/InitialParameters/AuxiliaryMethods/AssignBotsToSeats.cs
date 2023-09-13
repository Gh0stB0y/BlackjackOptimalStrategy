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
        public static void AssignBotsToSeats()
        {
            foreach(var seat in TableModel.Seats)
            {
                if (seat != null)
                {
                    if (!seat.SeatTaken)
                    {
                        seat.SeatTaken = true;
                        seat.SeatTakenByPlayer = false;
                        seat.SeatActive = true;                        
                    }
                }
            }
        }
    }
}
