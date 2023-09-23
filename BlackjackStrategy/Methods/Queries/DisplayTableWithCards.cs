using BlackjackStrategy.GameModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackStrategy.Methods.Queries
{
    public static partial class Queries
    {   
        public static void DisplayTableWithCards()
        {

            string dealerCards = string.Empty;
            string tabs = new string(' ',TableModel.Seats.Count*10-10);
            int maxCount = 0;
            foreach (var card in TableModel.DealerCards) dealerCards += CardsModel.CardNames[card]+", ";
            foreach (var Seat in TableModel.Seats)
            {
                if (Seat.Cards.Count > maxCount) maxCount = Seat.Cards.Count;
            }

            List<string> lines = Enumerable.Repeat("",maxCount).ToList();
            foreach (var Seat in TableModel.Seats)
            {
                for (int i = 0; i < maxCount; i++)
                {
                    if (i < Seat.Cards.Count)
                    {
                        lines[i] += CardsModel.CardNames[Seat.Cards[i]];
                        string spacje= new string(' ', 20- CardsModel.CardNames[Seat.Cards[i]].Length);
                        lines[i]+=spacje;
                    }
                    else lines[i] += new string(' ', 20);
                }
            }

            string bets = string.Empty;
            string seatsActive = string.Empty;
            string lastDecisions = string.Empty;
            foreach (var Seat in TableModel.Seats)
            {
                string bet = "bet: " + Seat.Bet.ToString();
                string seatActive = "Seat active: " + Seat.SeatActive.ToString();
                string lastDecision = "Last decision: " + Seat.LastDecision;
                bet = bet + new string(' ', 20 - bet.Length);
                bets += bet;
                seatActive = seatActive + new string(' ', 20 - seatActive.Length);
                seatsActive += seatActive;
                lastDecision = lastDecision + new string(' ', 20 - lastDecision.Length);
                lastDecisions += lastDecision;
            }

                Console.Clear();
            Console.Write(tabs); 
            Console.WriteLine("Dealer cards");
            Console.Write(tabs);
            Console.WriteLine(dealerCards+"\n\n");
            foreach(var line in lines) Console.WriteLine(line);
            Console.WriteLine(bets);
            Console.WriteLine(seatsActive);
            Console.WriteLine(lastDecisions);

            Console.ReadKey();
        }
    }
}
