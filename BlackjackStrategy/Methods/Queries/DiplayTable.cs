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
        public static void DiplayTable() 
        {
            List<string> lines=new() { "","","",""};    
            Console.Clear();
            foreach(var Seat in TableModel.Seats)
            {
                lines[0] += Seat.SeatId.ToString() + "\t";
                lines[1] += Seat.SeatTaken.ToString() + "\t";
                lines[2] += Seat.SeatTakenByPlayer.ToString() + "\t";
                lines[3] += Seat.SeatActive.ToString() + "\t";
            }
            Console.WriteLine("Id:            \t"+ lines[0]);
            Console.WriteLine("Seat taken:    \t" + lines[1]);
            Console.WriteLine("Player at seat:\t" + lines[2]);
            Console.WriteLine("Seat active:   \t" + lines[3]);
            Console.WriteLine("Press any key to proceed...");
            Console.ReadKey();
        }
    }
}
