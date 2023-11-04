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
        public static bool HandBusted(int seatId)
        {
            if (TableModel.Seats[seatId].Score > 21)
            {
                LoseGame(seatId, 1);
                return true;
            }
            else return false; 
        }
    }
}
