namespace BlackjackStrategy.GeneticAlgorythm.Interfaces
{
    public interface ISelection
    {
        List<ISpecimenModel> ParentSelection(List<ISpecimenModel> CurrentPopulation);
    }
}