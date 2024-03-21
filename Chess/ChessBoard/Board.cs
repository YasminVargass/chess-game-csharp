using Chess.Exceptions;

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

    public Piece Piece(Position pos)
    {
        return pieces[pos.Row, pos.Column];
    }

    public bool HasPiece(Position pos)
    {
        ValidPosition(pos);
        return Piece(pos) != null;

    }

    public void ValidPosition(Position pos)
    {
        if (pos.Row < 0 || pos.Row > Rows || pos.Column < 0 || pos.Column > Columns)
        {
            throw new PositionException("Posição inválida!");
        }
    }

    public void SetPiece(Piece p, Position pos)
    {
        if (HasPiece(pos))
        {
            throw new PositionException("Já existe uma peça nessa posição!");
        }
        pieces[pos.Row, pos.Column] = p; // A peça[1,1] é um rei
        p.Position = pos; //A posição do rei é a 1,1
    }
}
