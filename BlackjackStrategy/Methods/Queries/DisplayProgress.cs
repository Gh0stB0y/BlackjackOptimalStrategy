using BlackjackStrategy.GameModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackStrategy.Methods.Queries
{
    public static partial class Queries
    {
        public static void DisplayProgress(int i)
        {
            double progress = (double)i / PlayerModel.GamesPlayed*100;

            Console.WriteLine("Progress: " + progress.ToString("0.000"));                
        }
    }
}
