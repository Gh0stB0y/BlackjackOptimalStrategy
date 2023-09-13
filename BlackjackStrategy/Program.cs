using BlackjackStrategy.Methods.Commands;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my program :) Please set up game parameters");
        Commands.SetInitialParameters();
    }
}