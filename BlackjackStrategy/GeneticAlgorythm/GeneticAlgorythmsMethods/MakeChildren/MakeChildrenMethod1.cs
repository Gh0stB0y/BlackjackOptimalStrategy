using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackjackStrategy.GeneticAlgorythm.Interfaces;

namespace BlackjackStrategy.GeneticAlgorythm.GeneticAlgorythmsMethods.MakePairs
{
    internal class MakeChildrenMethod1 : IMakeChildren
    {
        public List<ISpecimenModel> MakeChildren(List<ISpecimenModel> parents, List<int> mutationFactor,
                                                    int howManyChildren, int generationNumber)
        {
            List<ISpecimenModel>newGeneration = new List<ISpecimenModel>();
            Random RNGMachine = new Random();
            for (int i=0; i<howManyChildren-1;i++)
            {
                int[] indexes = new int[2];
                do
                {
                    indexes[0] = RNGMachine.Next(0, parents.Count);
                    indexes[1] = RNGMachine.Next(0, parents.Count);
                } while (indexes[0] == indexes[1]);                
                List<int>[] parentBettingSystems = new List<int>[2]
                {
                    parents[indexes[0]].BettingSystem,
                    parents[indexes[1]].BettingSystem,
                };

                List<int> newBettingSystem = new List<int>();
                for(int j=0; j< parentBettingSystems.First().Count; j++)
                {
                    newBettingSystem.Add(parentBettingSystems[RNGMachine.Next(0, 2)][j]);                   
                }
                int mutatedIndex = RNGMachine.Next(0, newBettingSystem.Count);

                int mutationValue =0;
                if (generationNumber >= mutationFactor.Count)                
                    mutationValue = mutationFactor.Last();                
                else
                    mutationValue = mutationFactor[generationNumber];

                newBettingSystem[mutatedIndex] = newBettingSystem[mutatedIndex] + mutationValue * (RNGMachine.Next(0,2)*2-1);
                if (newBettingSystem[mutatedIndex] <= 0) newBettingSystem[mutatedIndex] = 1;

                ISpecimenModel child = Factory.CreateSpecimenModelInstance(newBettingSystem);
                newGeneration.Add(child);             
            }                           
            return newGeneration;
        }
    }
}
