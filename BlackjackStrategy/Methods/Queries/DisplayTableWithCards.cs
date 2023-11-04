using BlackjackStrategy.DataContainers;
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
           /* int howManySpaces = 30;
            string dealerCards = string.Empty;
            string dealerScore = TableModel.DealerScore.ToString();
            string tabs = new string(' ', TableModel.Seats.Count * howManySpaces / 2 - howManySpaces / 2);
            int maxCount = 0;
            foreach (var card in TableModel.DealerCards) dealerCards += CardsModel.CardNames[card] + ", ";
            foreach (var Seat in TableModel.Seats)
            {
                if (Seat.Cards.Count > maxCount) maxCount = Seat.Cards.Count;
            }

            List<string> lines = Enumerable.Repeat("", maxCount).ToList();
            foreach (var Seat in TableModel.Seats)
            {
                for (int i = 0; i < maxCount; i++)
                {
                    if (i < Seat.Cards.Count)
                    {
                        lines[i] += CardsModel.CardNames[Seat.Cards[i]];
                        string spacje = new string(' ', howManySpaces - CardsModel.CardNames[Seat.Cards[i]].Length);
                        lines[i] += spacje;
                    }
                    else lines[i] += new string(' ', howManySpaces);
                }
            }

            string bets = string.Empty;
            string seatsActive = string.Empty;
            string lastDecisions = string.Empty;
            string scores = string.Empty;
            string firstLine = "Bankroll: " + PlayerModel.Bankroll + ", Profit: " + PlayerModel.Bankroll;
            string winningStreaks = string.Empty;
            foreach (var Seat in TableModel.Seats)
            {
                string bet = "bet: " + Seat.Bet.ToString();
                string seatActive = "Seat active: " + Seat.SeatActive.ToString();
                string lastDecision = "Last decision: " + Seat.LastDecision;
                string score = "Score: " + Seat.Score.ToString();
                string winningStreak = "Streak: " + Seat.WinningStreak.ToString();
                bet = bet + new string(' ', howManySpaces - bet.Length);
                bets += bet;
                seatActive = seatActive + new string(' ', howManySpaces - seatActive.Length);
                seatsActive += seatActive;
                lastDecision = lastDecision + new string(' ', howManySpaces - lastDecision.Length);
                lastDecisions += lastDecision;
                score = score + new string(' ', howManySpaces - score.Length);
                scores += score;
                winningStreak = winningStreak + new string(' ', howManySpaces + winningStreak.Length);
                winningStreaks += winningStreak;
            }

            Console.Clear();
            //Console.WriteLine(firstLine);
            Console.Write(tabs);
            Console.WriteLine("Dealer cards");
            Console.Write(tabs);
            Console.WriteLine(dealerCards);
            Console.Write(tabs);
            Console.WriteLine(dealerScore + "\n\n");
            foreach (var line in lines) Console.WriteLine(line);
            Console.WriteLine(bets);
            Console.WriteLine(seatsActive);
            Console.WriteLine(lastDecisions);
            Console.WriteLine(scores);

            Console.ReadKey();*/
        }
    }
}
