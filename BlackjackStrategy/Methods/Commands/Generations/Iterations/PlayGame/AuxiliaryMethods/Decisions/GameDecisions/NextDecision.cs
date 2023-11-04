using BlackjackStrategy.DataContainers;
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
        public static void NextDecision(int seatId)
        {               
            Queries.Queries.DisplayTableWithCards();
            //Console.WriteLine("score in the method: " + TableModel.Seats[seatId].Score);
            if (TableModel.Seats[seatId].Score > 21)
            {
                TableModel.Seats[seatId].Score = 21;
                Statistics.Fuckups++;
            }
            int decision = ManageMoreCards(seatId);
            switch (decision)
            {
                case 1:
                case 3:
                case 6:
                    Hit(seatId);
                    break;
                case 2:
                case 4:
                    Stand(seatId);
                    break;
                default: throw new Exception("Decision issue");
            }                                     
        }
    }
}
