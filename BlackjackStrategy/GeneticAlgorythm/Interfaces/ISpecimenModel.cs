namespace BlackjackStrategy.GeneticAlgorythm.Interfaces
{
    public interface ISpecimenModel
    {
        List<int> BettingSystem { get; }
        double Score { get; set; }
    }
}