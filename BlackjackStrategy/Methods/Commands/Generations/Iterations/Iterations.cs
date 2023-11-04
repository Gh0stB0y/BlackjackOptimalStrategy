using BlackjackStrategy.DataContainers;
using BlackjackStrategy.GameModels;
using BlackjackStrategy.GeneticAlgorythm.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackStrategy.Methods.Commands
{
    public static class Iterations
    {
        public static void PerformIterations(IGeneticAlgorythm genAlgorythm, int generationNumber)
        {
            for (int i = 0; i < genAlgorythm.Iterations; i++)
            {
                PlayerModel.Bankroll = PlayerModel.InitialBankroll;
                Statistics.ClearStats();
                Console.WriteLine($"Generation {generationNumber}, iteration {i}");
                //string bankrollDataPath = WriteData.GeneratePath(generationNumber.ToString());
                for (int j = 0; j < PlayerModel.MaxGamesPlayed; j++)
                {
                    Commands.PlayGame();
                    /*if (j % 100 == 0)
                    {
                        WriteData.WriteDataToFile(new string[] { j.ToString(), PlayerModel.Bankroll.ToString() },
                                                    bankrollDataPath);
                    }*/
                    if (PlayerModel.Busted) break;
                }
                Commands.UpdateStatistics();
                WriteData.WriteDataFromIteration(generationNumber.ToString(),
                                                    new string[] {Statistics.Wins.ToString(), Statistics.Loses.ToString(),
                                                                    Statistics.Pushes.ToString(), Statistics.Winratio.ToString(),
                                                                        Statistics.Profit.ToString()});
                Statistics.ProfitFromIterations.Add(Statistics.Profit);

            }
        }

        public static double CalculateOptimizationParameter()
        {
            List<double> iterationProfits = Statistics.ProfitFromIterations.OrderBy(x=>x).ToList();

            double average = iterationProfits.Average();
            double sumOfSquaredDifferences = iterationProfits.Sum(value => Math.Pow(value - average, 2));
            double variance = sumOfSquaredDifferences / iterationProfits.Count;

            double standardDeviation = Math.Sqrt(variance);
            List<double> filteredProfits = iterationProfits.Where(value => Math.Abs(value - average) <= 1.5 * standardDeviation).ToList();


            return filteredProfits.Average();
        }
    }
}
