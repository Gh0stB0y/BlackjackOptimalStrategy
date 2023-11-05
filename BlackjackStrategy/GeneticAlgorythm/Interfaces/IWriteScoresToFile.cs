namespace BlackjackStrategy.GeneticAlgorythm.Interfaces
{
    public interface IWriteScoresToFile
    {
        void WriteScoresToFile(double bestScore, double worstScore, double meanScore);
    }
}