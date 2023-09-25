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
        public static int CompareValues(int seatId)
        {
            if (TableModel.Seats[seatId].Score < TableModel.DealerScore)
                return 0;
            else if(TableModel.Seats[seatId].Score == TableModel.DealerScore)
                return 1;
            else 
                return 2;
        }
    }
}
