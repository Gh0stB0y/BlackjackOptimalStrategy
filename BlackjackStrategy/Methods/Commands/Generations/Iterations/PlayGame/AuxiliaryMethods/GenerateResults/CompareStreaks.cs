using BlackjackStrategy.DataContainers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackStrategy.Methods.Commands.Generations.Iterations.PlayGame.AuxiliaryMethods.GenerateResults
{
    public static partial class CompareStreaks
    {
        public static void CompareWinStreak(int winStreak)
        {
            if (winStreak > Statistics.BiggestWinStreak)
                Statistics.BiggestWinStreak = winStreak;
        }
        public static void CompareLoseStreak(int loseStreak)
        {
            if (loseStreak > Statistics.BiggestLoseStreak)
                Statistics.BiggestLoseStreak = loseStreak;
        }
    }
}
