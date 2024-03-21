using Chess.ChessBoard;
namespace Chess;

public class Screen
{
    public static void PrintScreen(Board board)
    {
        for (int i = 0; i < board.Rows; i++)
        {
            for (int j = 0; j < board.Columns; j++)
            {
                if (board.Piece(i, j) == null)
                {
                    System.Console.Write("- ");
                }
                else
                {
                    System.Console.Write(board.Piece(i, j) + " ");
                }

            }
            System.Console.WriteLine();
        }

    }

}

