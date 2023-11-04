using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackjackStrategy.GeneticAlgorythm.GeneticAlgorythmsMethods;
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
    }
}
