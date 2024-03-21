using Chess.ChessBoard;

namespace Chess.ChessGame;

public class PositionChess
{
    public int Row { get; private set; }
    public char Column { get; private set; }

    public PositionChess(char column, int row)
    {
        Row = row;
        Column = column;
    }

    public Position toPosition()
    {
        return new Position(8 - Row, Column - 'a');
    }

    public override string ToString()
    {
        return "" + Row + Column;
    }

}
