using BlackjackStrategy.GameModels;
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
        public static List<int> ConvertInputToList(string input)
        {
            List<int> numbers = new List<int>();
            MatchCollection matches = Regex.Matches(input, @"\d+");

            foreach (Match match in matches)
            {
                if (int.TryParse(match.Value, out int number))
                {
                    if (number > TableModel.SeatsNumber || number < 1) Console.WriteLine($"Invalid integer: {match.Value}");
                    else
                    {
                        if (!numbers.Contains(number)) numbers.Add(number);
                        else Console.WriteLine("Seat already typed in input");
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid integer: {match.Value}");
                }
            }
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            return numbers;
        }
    }
}
