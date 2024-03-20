using Chess.ChessBoard;

namespace Chess.ChessGame;

public class Tower : Piece
{

    public Tower(Color color, Board board) : base(color, board)
    {

    }

    public override string ToString()
    {
        return "T";
    }

}
