namespace BlackjackStrategy.GeneticAlgorythm.Interfaces
{
    public interface ICreatePopulation
    {
        int InitialUnit { get; set; }
        int SystemLength { get; set; }
        int MaxUnit { get; set; }
        int MinUnit { get; set; }
        List<int> GenerateBettingSystem();
        List<List<int>> CollectBettingSystems(int bettingSystemsCount);
    }
}