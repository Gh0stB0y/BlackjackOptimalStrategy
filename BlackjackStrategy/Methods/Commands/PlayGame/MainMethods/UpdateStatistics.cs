using BlackjackStrategy.DataContainers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackStrategy.Methods.Commands
{
    public static partial class Commands
    {
        public static void UpdateStatistics()
        {
            //Statistics.Winratio = Statistics.Wins/(Statistics.Wins + Statistics.Loses);
            Console.WriteLine($"Wins: {Statistics.Wins}, Loses: {Statistics.Loses}, Pushes: {Statistics.Pushes}, Fuckups: {Statistics.fuckups}");
        }
    }
}
