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

            foreach(var specimen in _genAlgorythm.CurrentPopulation)
            {
                foreach(var item in specimen.BettingSystem)
                {
                    Console.Write(item+"/");
                }
                Console.WriteLine();
            }

            /*for(int i = 0; i < _genAlgorythm.Generations; i++)
            {
                int generationNumber = i;
                foreach (var specimen in _genAlgorythm.CurrentPopulation)
                {
                    //KOD OBLICZAJACY PROFIT Z DANEGO OSOBNIKA
                    SpecimenScore.CalculateSpecimenScore(_genAlgorythm, generationNumber, specimen);
                    //
                }
                _genAlgorythm.ChooseEliteSpecimen();
                _genAlgorythm.CompareIndividuals();
                _genAlgorythm.DrawParents();
                _genAlgorythm.MakeChildren();

            }
            _genAlgorythm.AlgorythmSummary();*/
        }

        

    }
}
