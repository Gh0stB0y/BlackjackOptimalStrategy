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

        public List<int>Cards = new();
        public SeatModel(int id) { SeatId = id; }
    }
}
