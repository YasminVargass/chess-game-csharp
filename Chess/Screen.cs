using Chess.ChessBoard;
using Chess.ChessGame;
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

        System.Console.WriteLine();
    }
    public static PositionChess ReadPlay()
    {
        string s = Console.ReadLine();
        char column = s[0];
        int row = int.Parse(s[1] + "");
        return new PositionChess(column, row);
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
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.Write(piece);
            Console.ForegroundColor = standard;
        }
    }

}

