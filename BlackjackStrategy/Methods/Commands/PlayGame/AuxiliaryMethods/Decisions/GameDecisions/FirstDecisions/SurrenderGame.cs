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
        public static void SurrenderGame(int seatId)
        {
            TableModel.Seats[seatId].LastDecision = "Surrender";
            LoseGame(seatId, 0.5);
        }
    }
}
