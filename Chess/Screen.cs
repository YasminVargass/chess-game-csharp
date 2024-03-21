using Chess.ChessBoard;
namespace Chess;

public class Screen
{
    public static void PrintScreen(Board board)
    {
        for (int i = 0; i < board.Rows; i++)
        {
            System.Console.Write(8 - i + " ");
            for (int j = 0; j < board.Columns; j++)
            {
                if (board.Piece(i, j) == null)
                {
                    System.Console.Write("- ");
                }
                else
                {
                    PrintPiece(board.Piece(i, j));
                    System.Console.Write(" ");
                }

            }

            System.Console.WriteLine();
        }
        System.Console.Write("  " + "A B C D E F G H");

    }

    public static void PrintPiece(Piece piece)
    {
        if (piece.Color == Color.White)
        {
            System.Console.Write(piece);
        }
        else
        {
            ConsoleColor standard = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.Write(piece);
            Console.ForegroundColor = standard;
        }
    }

}

