 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackStrategy.GameModels
{
    public static class TableModel
    {
        //INITIAL PARAMETERS
        public static int SeatsNumber {get; set;} = 1;
        public static int DecksNumber { get; set; } = 6;
        public static bool StandOnSoft17 { get; set; } = true;
        public static bool Surrender { get; set; } = false;
        public static bool CsmEnabled { get; set; } = false;
        public static bool SecondDealerCard { get; set; } = false;
        public static bool BotPlayers { get; set; } = false;
        //

        //GAME PARAMETERS
        public static List<SeatModel> Seats = new();
        public static List<int>DealerCards { get; set; } = new();
        public static int DealerScore { get; set; } = 0;
        public static Stack<int> ShoeCards { get; set; } = new();
        public static int CardsPlayed { get; set; } = 0;
        public static int RedCard { get; set; } = 0;
        public static bool DealerBusted { get; set; } = false; 
    }
}
