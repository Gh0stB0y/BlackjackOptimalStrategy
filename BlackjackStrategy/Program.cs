using BlackjackStrategy.GameModels;
using BlackjackStrategy.Methods.Commands;
using BlackjackStrategy.Methods.Queries;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my program :) Please set up game parameters");
        Commands.SetInitialParameters();
        Queries.DiplayTableNoCards();
        if (!TableModel.CsmEnabled) Commands.ShuffleCards();

        for (int i = 0; i < 5; i++)
            Commands.PlayGame();

    }
}