using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackjackStrategy.GeneticAlgorythm.Interfaces;

namespace BlackjackStrategy.GeneticAlgorythm
{
    public class GeneticAlgorythm : IGeneticAlgorythm, IGeneticCharts
    {
        public double FinalScore { get; private set; }
        public int Generations { get; private set; }
        public int Iterations { get; private set; }
        public int PopulationSize { get; private set; }
        public List<ISpecimenModel> CurrentPopulation { get; set; }
        public ISpecimenModel EliteSpecimen { get; set; }
        public List<int> MutationFactor { get; set; }
        public void ChooseEliteSpecimen() { }
        public void CompareIndividuals() { }
        public void DrawParents() { }
        public void MakeChildren() { }
        public void AlgorythmSummary() { }

        ////////////////////////////////////////////////////

        public List<int> GenerationBestScore { get; set; }
        public void DrawPerformanceChart() { }
        public void DrawStandardDeviationChart() { }

        //dorobic jakies wlasciwosci przedstawiajace eksploracje i eksploatacje

        public GeneticAlgorythm()
        {
            Generations = 1;
            Iterations = 500;
            PopulationSize = 10;
            CurrentPopulation = new List<ISpecimenModel>();
            EliteSpecimen = Factory.CreateSpecimenModelInstance(new List<int>() {1});
            MutationFactor = new() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            GenerationBestScore = new List<int>();
        }

        public void CreatePopulation()
        {
            ICreatePopulation _createPopulation = Factory.CreatePopulationMethod();

            _createPopulation.InitialUnit = 1;
            _createPopulation.SystemLength = 6;
            _createPopulation.MaxUnit = 5;
            _createPopulation.MinUnit = 1;
            CurrentPopulation.Clear();
            List<List<int>> generatedLists = new List<List<int>>();    
            
            generatedLists = _createPopulation.CollectBettingSystems(PopulationSize);
            foreach (List<int> bettingSystem in generatedLists)
            {
                CurrentPopulation.Add(Factory.CreateSpecimenModelInstance(bettingSystem));
            }
        }
    }
}
