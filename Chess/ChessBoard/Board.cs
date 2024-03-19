namespace Chess.ChessBoard;

public class Board
{
    public int Rows { get; private set; }
    public int Columns { get; private set; }

    private Piece[,] piece;

    public Board(int rows, int columns)
    {
        Rows = rows;
        Columns = columns;
        piece = new Piece[rows, columns];
    }


}
