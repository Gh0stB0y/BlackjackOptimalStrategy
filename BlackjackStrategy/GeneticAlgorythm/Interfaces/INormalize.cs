using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackStrategy.GeneticAlgorythm.Interfaces
{
    public interface INormalize
    {
        //List<ISpecimenModel> Normalize(List<ISpecimenModel> inputPopulation);
        void Normalize(List<ISpecimenModel> inputPopulation);
    }
}
