using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackStrategy.Methods.Commands
{
    public static partial class Commands
    {
        public static bool CheckInputBool(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input is null!");
                return false;
            }
            else
            {
                if (input.ToLower() == "y" || input.ToLower() == "n") return true;
                else
                {
                    Console.WriteLine("Wrong input");
                    return false;
                }
            }
        }
    }
}
