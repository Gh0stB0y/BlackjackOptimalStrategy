using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackStrategy.DataContainers
{
    public static class Statistics
    {
        public static int Wins { get; set; } = 0;
        public static int Loses { get; set; } = 0;
        public static double Winratio { get; set; } = 0;
        public static double Profit { get; set; } = 0;
    }
}
