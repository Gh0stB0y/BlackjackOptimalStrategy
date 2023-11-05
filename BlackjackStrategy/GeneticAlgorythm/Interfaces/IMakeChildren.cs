namespace BlackjackStrategy.GeneticAlgorythm.Interfaces
{
    public interface IMakeChildren
    {
        List<ISpecimenModel> MakeChildren(List<ISpecimenModel>parents, List<int>mutationFactor, int howManyChildren, int generationNumber);
    }
}