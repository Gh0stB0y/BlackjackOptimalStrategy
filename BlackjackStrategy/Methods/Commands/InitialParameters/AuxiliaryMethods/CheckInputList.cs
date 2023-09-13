using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BlackjackStrategy.Methods.Commands
{
    public static partial class Commands
    {
        public static bool CheckInputList(string input)
        {
            List<int> numbers = new List<int>();
            MatchCollection matches = Regex.Matches(input, @"\d+");
            if (matches.Count == 0) 
            {
                Console.WriteLine("Empty list");
                return false;
            }
            else
            {
                foreach(Match match in matches)
                {
                    if (!int.TryParse(match.Value, out int confirmedInput) || confirmedInput <= 0)
                    {
                        Console.WriteLine("Negative integer");
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
