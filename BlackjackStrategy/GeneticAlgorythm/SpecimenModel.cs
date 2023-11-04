using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackjackStrategy.GeneticAlgorythm.Interfaces;

namespace BlackjackStrategy.GeneticAlgorythm
{
    public class SpecimenModel : ISpecimenModel
    {
        public List<int> BettingSystem { get; private set; }
        public double Score { get; set; } 
        public SpecimenModel(List<int> bettingSystem) 
        { 
            BettingSystem = bettingSystem;
            Score = 0;
        }
    }
}
