using BlackjackStrategy.GameModels;
using BlackjackStrategy.GeneticAlgorythm.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackStrategy.Methods.Commands
{
    public static class SpecimenScore
    {
        public static void CalculateSpecimenScore(IGeneticAlgorythm genAlgorythm, int generationNumber, ISpecimenModel specimen)
        {
            PlayerModel.BettingSystem = specimen.BettingSystem; // przypisanie betting systemu
            Iterations.PerformIterations(genAlgorythm, generationNumber);
            specimen.Score  = Iterations.CalculateOptimizationParameter(); //! output !
            
            Console.WriteLine($"Average Profit: {specimen.Score}");
        } 
    }
}
