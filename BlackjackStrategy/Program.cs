using BlackjackStrategy.GameModels;
using BlackjackStrategy.Methods.Commands;
using BlackjackStrategy.Methods.Queries;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my program :) Please set up game parameters");
        Commands.SetInitialParameters();
        Queries.DiplayTable();
        if (!TableModel.CsmEnabled) Commands.ShuffleCards();

        for (int i = 0; i < PlayerModel.GamesPlayed; i++) Commands.PlayGame();

    }
}