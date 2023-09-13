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
        public static void AssignPlayerToSeats(List<int>seatIDs)
        {
            foreach(int id in seatIDs)
            {
                TableModel.Seats[id - 1].SeatTaken=true;
                TableModel.Seats[id - 1].SeatTakenByPlayer = true;
                TableModel.Seats[id - 1].SeatActive = true;
            }
        }
    }
}
