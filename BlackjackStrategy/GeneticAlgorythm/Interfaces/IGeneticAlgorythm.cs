namespace BlackjackStrategy.GeneticAlgorythm.Interfaces
{
    public interface IGeneticAlgorythm
    {
        double FinalScore { get; }
        int Generations { get; }
        int Iterations { get; }
        int PopulationSize { get; }
        List<ISpecimenModel> CurrentPopulation { get; } // List of persons, in this case betting system
        ISpecimenModel EliteSpecimen { get; }
        List<int> MutationFactor { get; }
        void CreatePopulation();
        void ChooseEliteSpecimen();
        void CompareIndividuals();
        void DrawParents();
        void MakeChildren();
        void AlgorythmSummary();
    }
}