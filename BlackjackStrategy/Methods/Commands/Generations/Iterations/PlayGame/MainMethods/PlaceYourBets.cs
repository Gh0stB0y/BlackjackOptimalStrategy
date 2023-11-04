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
        public static void PlaceYourBets()
        {
           
            foreach (var seat in TableModel.Seats)
            {
                if (seat.SeatTaken)
                {
                    if (seat.SeatTakenByPlayer)
                    {
                        int currentBetIndex = seat.WinningStreak % PlayerModel.BettingSystem.Count;
                        seat.Bet = PlayerModel.BettingSystem[currentBetIndex];
                        //if (seat.SeatTakenByPlayer)
                        //{
                            if (PlayerModel.Bankroll - seat.Bet < 0)
                                PlayerRuined();
                            else
                            {
                                PlayerModel.Bankroll -= seat.Bet;
                            }
                        //}
                    }
                    else
                    {
                        seat.Bet = 1;
                    }
                }
                else seat.Bet = 0;
                }
        }
    }
}
