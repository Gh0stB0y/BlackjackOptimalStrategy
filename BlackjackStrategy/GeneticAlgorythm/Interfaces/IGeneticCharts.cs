namespace BlackjackStrategy.GeneticAlgorythm.Interfaces
{
    public interface IGeneticCharts
    {
        List<int> GenerationBestScore { get; set; }
        void DrawPerformanceChart();
        void DrawStandardDeviationChart();
    }
}