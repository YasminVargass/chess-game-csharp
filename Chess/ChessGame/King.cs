using Chess.ChessBoard;

namespace Chess.ChessGame;

public class King : Piece
{

    public King(Color color, Board board) : base(color, board)
    {

    }

    public override string ToString()
    {
        return "R";
    }

}
