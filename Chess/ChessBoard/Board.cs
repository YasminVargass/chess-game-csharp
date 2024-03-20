namespace Chess.ChessBoard;

public class Board
{
    public int Rows { get; private set; }
    public int Columns { get; private set; }

    private Piece[,] pieces;

    public Board(int rows, int columns)
    {
        Rows = rows;
        Columns = columns;
        pieces = new Piece[rows, columns];
    }

    public Piece Piece(int row, int column)
    {
        return pieces[row, column];
    }
    public void SetPiece(Piece p, Position pos)
    {
        pieces[pos.Row, pos.Column] = p;
        p.Position = pos;
    }

}
