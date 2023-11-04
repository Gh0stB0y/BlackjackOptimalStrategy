using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackStrategy.GameModels
{
    public class SeatModel
    {
        public int SeatId { get; set; } = 0;
        public bool SeatTaken { get; set; } = false;
        public bool SeatTakenByPlayer { get; set; } = false;
        public bool SeatActive { get; set; } = false;

        public List<int>Cards { get; set; } = new();
        public int Score { get; set; } = 0;
        public int AceCount { get; set; } = 0;

        public int WinningStreak { get; set; } = 0;
        public int LosingStreak { get; set; } = 0;
        public int Bet { get; set; } = 1;

        public bool AdditionalSeat { get; set; } = false;

        public string LastDecision { get; set; } = string.Empty;
        //
        public SeatModel(int id) { SeatId = id; }
    }
}
