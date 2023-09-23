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
        public static void ShuffleCards()
        {
            TableModel.ShoeCards.Clear();
            List<int> CardsStorage = Enumerable.Repeat(TableModel.DecksNumber, 52).ToList();
            List<int> AvailableCards = new List<int>();
            for (int j = 0; j < 52; j++) AvailableCards.Add(j);
            Random RandomObj = new Random();
            int RandomNumber;

            if (TableModel.DecksNumber > 0)
            {
                List<int> preShuffledDeck = new();
                for (int j = 0; j < 52 * TableModel.DecksNumber; j++)
                {
                    RandomNumber = RandomObj.Next(0, AvailableCards.Count);
                    var IndexOfMyCard = AvailableCards[RandomNumber];
                    CardsStorage[IndexOfMyCard]--;
                    preShuffledDeck.Add(IndexOfMyCard);
                    if (CardsStorage[IndexOfMyCard] == 0) AvailableCards.RemoveAt(RandomNumber);
                }

                Random random = new Random();
                int n = preShuffledDeck.Count;
                for (int i = n - 1; i > 0; i--)
                {
                    int j = random.Next(0, i + 1);
                    int temp = preShuffledDeck[i];
                    preShuffledDeck[i] = preShuffledDeck[j];
                    preShuffledDeck[j] = temp;
                }

                foreach (int card in preShuffledDeck) TableModel.ShoeCards.Push(card);

                TableModel.CardsPlayed = 0;
                double RedCardPercent = RandomObj.Next(600, 850) * 52 * TableModel.DecksNumber / 1000;// * 52 * NumberOfDecks;
                TableModel.RedCard = (int)Math.Floor(RedCardPercent);
                Console.WriteLine("RedCard: " + TableModel.RedCard);
            }
        }
    }
}
