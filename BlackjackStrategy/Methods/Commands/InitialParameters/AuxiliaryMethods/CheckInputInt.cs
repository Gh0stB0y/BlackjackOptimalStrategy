using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackStrategy.Methods.Commands
{
    public static partial class Commands
    {
        public static bool CheckInputInt(string input,int maxIntVal)
        {
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input is null!");
                return false;
            }
            else
            {
                if (int.TryParse(input, out int confirmedInput)) 
                {
                    if(confirmedInput <= maxIntVal && confirmedInput>0) return true;
                    else if (confirmedInput <= maxIntVal && confirmedInput <= 0)
                    {
                        Console.WriteLine("Input value is too small!");
                        return false;
                    }
                    else
                    {
                        Console.WriteLine("Input value is too big!");
                        return false;
                    }
                }                
                else
                {
                    Console.WriteLine("Input is not an int!");
                    return false;
                }
            }
        }
    }
}
