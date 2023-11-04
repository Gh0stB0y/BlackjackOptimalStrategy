using BlackjackStrategy.DataContainers;
using BlackjackStrategy.GameModels;
using BlackjackStrategy.GeneticAlgorythm;
using BlackjackStrategy.Methods.Commands;
using BlackjackStrategy.Methods.Commands.Generations.Iterations;
using BlackjackStrategy.Methods.Queries;

namespace BlackjackStrategy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my program :) Please set up game parameters");
            Commands.SetInitialParameters();
            Queries.DiplayTableNoCards();
            if (TableModel.CsmEnabled == false) Commands.ShuffleCards();

            IGeneticAlgorythm genAlgorythm = Factory.CreateAlgorythmInstance();
            genAlgorythm.CreatePopulation();

            int generationNumber = 1;
            foreach (var subject in genAlgorythm.CurrentPopulation)
            {

            }
            //KOD ZWRACAJACY PROFIT Z DANEGO OSOBNIKA
            Iterations.PerformIterations(genAlgorythm, generationNumber);
            double IndividualScore = Iterations.CalculateOptimizationParameter();
            Console.WriteLine($"Average Profit: {IndividualScore}");
            //
        }

        
    }
}
