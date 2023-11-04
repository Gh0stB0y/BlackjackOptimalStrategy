namespace BlackjackStrategy.GeneticAlgorythm
{
    public interface IGeneticAlgorythm
    {
        double FinalScore { get; }
        int Generations { get; }
        int Iterations { get; }
        int PopulationSize { get; }
        List<List<int>> CurrentPopulation { get; } // List of persons, in this case betting system
        List<int> EliteBetPattern { get; }
        List<int> MutationFactor { get; }
        void CreatePopulation();      
        void ChooseEliteIndividual();
        void DrawPairs();
        void CompareIndividuals();                
        void DrawParents();
        void MakeChildren();
        void AlgorythmSummary();
    }
}