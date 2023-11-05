using BlackjackStrategy.GeneticAlgorythm.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackStrategy.GeneticAlgorythm.GeneticAlgorythmsMethods.Selection
{
    internal class TournamentSelection : ISelection
    {
        public int SpecimenNumberInFight { get; set; } = 2;
        public List<ISpecimenModel> ParentSelection(List<ISpecimenModel> CurrentPopulation)
        {
            List<ISpecimenModel> tempPopulation = CurrentPopulation;
            List<ISpecimenModel> winningSpecimens = new List<ISpecimenModel>();
            List<ISpecimenModel> fighters = new List<ISpecimenModel>();
            Random RNGMachine = new Random();

            while(tempPopulation.Count/ SpecimenNumberInFight >= 1)
            {
                //Console.WriteLine($"TempPopulation count: {tempPopulation.Count}");
                fighters.Clear();
                for(int i = 0; i < SpecimenNumberInFight; i++)
                {
                    int index = RNGMachine.Next(0, tempPopulation.Count);
                    fighters.Add(tempPopulation[index]);
                    tempPopulation.RemoveAt(index);
                }
                //foreach(var fighter in fighters) Console.WriteLine($"Fighter score: {fighter.Score}");
                
                winningSpecimens.Add(fighters.OrderByDescending(x => x.Score).First());
            }
            winningSpecimens.AddRange(tempPopulation); // luckers / wildcard
            //foreach(var winner in winningSpecimens) Console.WriteLine($"Winner score: {winner.Score}");
            return winningSpecimens;
        }

    }
}
