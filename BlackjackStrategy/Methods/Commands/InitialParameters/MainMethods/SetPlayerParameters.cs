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
        public static void SetPlayerParameters()
        {
            Console.Clear();
            string input;
            Console.WriteLine("Set player parameters:");

            do {
                Console.Write("Counting cards (Y/N): ");
                input = Console.ReadLine();
            } while (!CheckInputBool(input));
            if (input.ToLower() == "y") PlayerModel.CountingCards = true;
            else PlayerModel.CountingCards = false;

            do {
                Console.Write("Bankroll (in units): ");
                input = Console.ReadLine();
            } while (!CheckInputInt(input, 100000000));
            PlayerModel.Bankroll = int.Parse(input);

            do {
                Console.Write("Games played: ");
                input = Console.ReadLine();
            } while (!CheckInputInt(input, 100000000));
            PlayerModel.GamesPlayed = int.Parse(input);

            do {
                Console.Write("Which seats (ID) are taken by player (split IDs with delimiter /, e.g. 1/2/34/1/4 ): ");
                input = Console.ReadLine();
            } while (!CheckInputList(input));
            PlayerModel.SeatsTaken = ConvertInputToList(input);
            AssignPlayerToSeats(PlayerModel.SeatsTaken);

            do {
                Console.Write("Define betting system (split values with delimiter /, e.g. 1/2/34/1/4: ");
                input = Console.ReadLine();
            } while (!CheckInputList(input));
            PlayerModel.BettingSystem = ConvertInputToList(input);
        }
    }
}
