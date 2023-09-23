using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackStrategy.DataContainers
{
    public class Statistics
    {
        public int wins { get; set; } = 0;
        public int loses { get; set; } = 0;
        public double winratio { get; set; } = 0;
        public int profit { get; set; } = 0;
    }
}
