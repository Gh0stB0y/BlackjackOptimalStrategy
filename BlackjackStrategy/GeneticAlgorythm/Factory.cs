using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackjackStrategy.GeneticAlgorythm.GeneticAlgorythmsMethods;
using BlackjackStrategy.GeneticAlgorythm.GeneticAlgorythmsMethods.MakePairs;
using BlackjackStrategy.GeneticAlgorythm.GeneticAlgorythmsMethods.Selection;
using BlackjackStrategy.GeneticAlgorythm.GeneticAlgorythmsMethods.WriteScoresToFile;
using BlackjackStrategy.GeneticAlgorythm.Interfaces;


namespace BlackjackStrategy.GeneticAlgorythm
{
    public static class Factory
    {
        public static IGeneticAlgorythm CreateAlgorythmInstance()
        {
            return new GeneticAlgorythm();
        }
        public static ICreatePopulation CreatePopulationMethod() 
        {
            return new CreatePopulationMethod();
        }
        public static ISpecimenModel CreateSpecimenModelInstance(List<int> bettingSystem)
        {
            return new SpecimenModel(bettingSystem);
        }
        public static IWriteScoresToFile CreateWriteScoresToFileMethod()
        {
            return new WriteScoresToFileMethod1();
        }
        public static INormalize CreateNormalizeMethod()
        {
            return new NormalizeMethod();
        }
        public static ISelection CreateSelectionMethod()
        {
            return new TournamentSelection();
        }
        public static IMakeChildren CreateMakeChildrenMethod()
        {
            return new MakeChildrenMethod1();
        }
    }
}
