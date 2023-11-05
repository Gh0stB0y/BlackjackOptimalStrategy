using BlackjackStrategy.GeneticAlgorythm.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackStrategy.GeneticAlgorythm.GeneticAlgorythmsMethods
{
    internal class NormalizeMethod : INormalize
    {
        public void Normalize(List<ISpecimenModel> inputPopulation)
        {
            inputPopulation = inputPopulation.OrderByDescending(x => x.Score).ToList();
            double maxScore = inputPopulation.First().Score;
            double minScore = inputPopulation.Last().Score;
            foreach (var specimen in inputPopulation)
            {
                specimen.Score = (specimen.Score - minScore) / (maxScore - minScore);
            }
        }

    }
}
