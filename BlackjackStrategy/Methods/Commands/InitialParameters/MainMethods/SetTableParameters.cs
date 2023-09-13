
using BlackjackStrategy.GameModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackStrategy.Methods.Commands
{
    public static partial class Commands
    {
        public static void SetTableParameters()
        {
            string input;
            Console.WriteLine("Set table parameters:");

            do {
                Console.Write("Number of seats: ");
                input = Console.ReadLine();
            } while (!CheckInputInt(input, 8));
                TableModel.SeatsNumber=int.Parse(input);

            do {
                Console.Write("Number of decks: ");
                input = Console.ReadLine();
            } while (!CheckInputInt(input, 8));
            TableModel.DecksNumber = int.Parse(input);

            do {
                Console.Write("Stand On Soft 17 (Y/N): ");
                input = Console.ReadLine();
            } while (!CheckInputBool(input));
            if(input.ToLower()=="y")TableModel.StandOnSoft17 = true;
            else TableModel.StandOnSoft17 = false;

            do {
                Console.Write("Surrender (Y/N): ");
                input = Console.ReadLine();
            } while (!CheckInputBool(input));
            if (input.ToLower() == "y") TableModel.Surrender = true;
            else TableModel.Surrender = false;

            do {
                Console.Write("Csm enabled (Y/N): ");
                input = Console.ReadLine();
            } while (!CheckInputBool(input));
            if (input.ToLower() == "y") TableModel.CsmEnabled = true;
            else TableModel.CsmEnabled = false;

            do {
                Console.Write("Second dealer card (Y/N): ");
                input = Console.ReadLine();
            } while (!CheckInputBool(input));
            if (input.ToLower() == "y") TableModel.SecondDealerCard = true;
            else TableModel.SecondDealerCard = false;

            do {
                Console.Write("Bot players enabled (Y/N): ");
                input = Console.ReadLine();
            } while (!CheckInputBool(input));
            if (input.ToLower() == "y") TableModel.BotPlayers = true;
            else TableModel.BotPlayers = false;
        }
    }
}
