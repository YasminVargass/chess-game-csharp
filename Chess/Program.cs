using Chess;
using Chess.ChessBoard;
using Chess.ChessGame;
using Chess.Exceptions;
try
{
    Match match = new Match();
    while (!match.EndGame)
    {
        Console.Clear();
        Screen.PrintScreen(match.Board);

        Console.WriteLine();
        System.Console.Write("Origem: ");
        Position origin = Screen.ReadPlay().toPosition();
        System.Console.Write("Destino: ");
        Position destination = Screen.ReadPlay().toPosition();

        match.MovePiece(origin, destination);
    }
}
catch (PositionException e)
{
    System.Console.WriteLine(e.Message);
}
catch (FormatException e)
{
    System.Console.WriteLine("Error: " + e.Message);
}