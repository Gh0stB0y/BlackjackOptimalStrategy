using BlackjackStrategy.GameModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackjackStrategy.Methods.Queries;
namespace BlackjackStrategy.Methods.Commands
{
    public static partial class Commands
    {
        public static void InitialCards()
        {
            for (int i = 0; i < 2; i++) 
            { 
                int seatId=TableModel.Seats.Count-1;
                do
                {
                   if (TableModel.Seats[seatId].SeatActive)GetACard(seatId);
                   seatId--;
                } while (seatId >= 0);

                if (i == 0 || (i == 1 && TableModel.SecondDealerCard == true)) GetADealerCard();
            }  
        }
    }
}
