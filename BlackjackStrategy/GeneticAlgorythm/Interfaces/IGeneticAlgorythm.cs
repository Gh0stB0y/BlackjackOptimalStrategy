namespace BlackjackStrategy.GeneticAlgorythm.Interfaces
{
    public interface IGeneticAlgorythm
    {
        ISpecimenModel FinalSpecimen { get; }
        int Generations { get; }
        int Iterations { get; }
        int PopulationSize { get; }
        List<ISpecimenModel> CurrentPopulation { get; } // List of persons, in this case betting system
        ISpecimenModel EliteSpecimen { get; }
        List<ISpecimenModel> Parents { get; }
        List<int> MutationFactor { get; }
        void WriteScoresToFile();
        void CreatePopulation();
        void NormalizeScore();
        void ChooseEliteSpecimen();
        void Selection();
        void MakeChildren(int generationNumber);
        void AlgorythmSummary();
    }
}