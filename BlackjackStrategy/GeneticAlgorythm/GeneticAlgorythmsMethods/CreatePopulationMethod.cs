using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackjackStrategy.GeneticAlgorythm.Interfaces;

namespace BlackjackStrategy.GeneticAlgorythm.GeneticAlgorythmsMethods
{
    internal class CreatePopulationMethod : ICreatePopulation
    {
        public int InitialUnit {get; set;} = 0;

        public int SystemLength { get; set; } = 0;

        public int MaxUnit { get; set; } = 0;

        public int MinUnit { get; set; } = 0;

        public List<int> GenerateBettingSystem()
        {
            List<int> bettingSystem = new List<int>() { InitialUnit };
            Random RNGmachine = new Random();
            for(int i = 0;i<SystemLength-1;i++)
            {
                bettingSystem.Add(RNGmachine.Next(MinUnit,MaxUnit+1));
            }

            return bettingSystem;
        }
        public List<List<int>> CollectBettingSystems(int bettingSystemsCount)
        {
            List<List<int>> lists = new();
            for (int i = 0; i < bettingSystemsCount; i++)
            {
                List<int> bettingSystem = new();
                do
                {
                    bettingSystem.Clear();
                    bettingSystem =GenerateBettingSystem();
                } while (lists.Contains(bettingSystem));

                lists.Add(bettingSystem);
            }
            return lists;
        }



        public CreatePopulationMethod() { }
    }
}
