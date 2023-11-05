using BlackjackStrategy.DataContainers;
using BlackjackStrategy.GameModels;
using BlackjackStrategy.GeneticAlgorythm;
using BlackjackStrategy.GeneticAlgorythm.Interfaces;
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

            IGeneticAlgorythm _genAlgorythm = Factory.CreateAlgorythmInstance();
            _genAlgorythm.CreatePopulation();

            for (int i = 0; i < _genAlgorythm.Generations; i++)
            {
                int generationNumber = i;
                int specimenNumber = 0;
                foreach (var specimen in _genAlgorythm.CurrentPopulation)
                {
                    //KOD OBLICZAJACY PROFIT Z DANEGO OSOBNIKA
                    SpecimenScore.CalculateSpecimenScore(_genAlgorythm, generationNumber, specimenNumber, specimen);
                    specimenNumber++;
                    //
                    Console.WriteLine($"Generation {generationNumber}/{_genAlgorythm.Generations}, specimen {specimenNumber}/{_genAlgorythm.CurrentPopulation.Count}");
                }
                _genAlgorythm.WriteScoresToFile();
                _genAlgorythm.ChooseEliteSpecimen();
                _genAlgorythm.NormalizeScore();                
                _genAlgorythm.Selection();
                _genAlgorythm.MakeChildren(generationNumber);
                Console.WriteLine();
            }
            _genAlgorythm.AlgorythmSummary();
        }

        

    }
}
