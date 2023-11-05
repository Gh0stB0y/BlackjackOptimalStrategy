using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackjackStrategy.GeneticAlgorythm.Interfaces;
using BlackjackStrategy.Methods.Commands;

namespace BlackjackStrategy.GeneticAlgorythm.GeneticAlgorythmsMethods.WriteScoresToFile
{
    internal class WriteScoresToFileMethod1 : IWriteScoresToFile
    {
        public void WriteScoresToFile(double bestScore, double worstScore, double meanScore)
        {
            WriteData.WriteDataToFile(new string[] { bestScore.ToString(),worstScore.ToString(),meanScore.ToString() },
                                                        "PerformanceChart.csv");
        }

    }
}
