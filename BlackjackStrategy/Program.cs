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
        if (TableModel.CsmEnabled == false) Commands.ShuffleCards();

        for (int i = 0; i < PlayerModel.GamesPlayed; i++)
        {
            //Queries.DisplayProgress(i);
            Commands.PlayGame();
        }
            
        Commands.UpdateStatistics();
    }
}