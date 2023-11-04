using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackStrategy.GeneticAlgorythm
{
    public class GeneticAlgorythm : IGeneticAlgorythm, IGeneticCharts
    {
        public double FinalScore { get; private set; }        
        public int Generations { get; private set; }
        public int Iterations { get; private set; }
        public int PopulationSize { get; private set; }
        public List<List<int>> CurrentPopulation { get; set; }
        public List<int> EliteBetPattern { get; set; }
        public List<int> MutationFactor { get; set; }        
        public void CreatePopulation() { }
        public void ChooseEliteIndividual() { }
        public void DrawPairs() { }
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
            Generations = 10;
            Iterations = 500;            
            PopulationSize = 10;
            EliteBetPattern = new();
            MutationFactor = new() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
        }
    }
}
