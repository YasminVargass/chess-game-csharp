using Chess.ChessBoard;

namespace Chess.ChessGame;

public class Match
{

    public Board Board { get; private set; }
    private int _turn;
    private Color _player;
    public bool EndGame { get; private set; }

    public Match()
    {
        Board = new Board(8, 8);
        _turn = 1;
        _player = Color.White;
        EndGame = false;
        SetMatchPieces();
    }

    public void MovePiece(Position origin, Position destination)
    {
        Piece p = Board.RemovePiece(origin);
        p.IncreaseMovements();
        Piece EnemysPiece = Board.RemovePiece(destination);
        Board.SetPiece(p, destination);
    }
    private void SetMatchPieces()
    {
        //WHITE

        Board.SetPiece(new Tower(Color.White, Board), new PositionChess('c', 1).toPosition());
        Board.SetPiece(new Tower(Color.White, Board), new PositionChess('c', 2).toPosition());
        Board.SetPiece(new Tower(Color.White, Board), new PositionChess('d', 2).toPosition());
        Board.SetPiece(new Tower(Color.White, Board), new PositionChess('e', 1).toPosition());
        Board.SetPiece(new Tower(Color.White, Board), new PositionChess('e', 2).toPosition());
        Board.SetPiece(new King(Color.White, Board), new PositionChess('d', 1).toPosition());

        //BLACK

        Board.SetPiece(new Tower(Color.Black, Board), new PositionChess('c', 7).toPosition());
        Board.SetPiece(new Tower(Color.Black, Board), new PositionChess('c', 8).toPosition());
        Board.SetPiece(new Tower(Color.Black, Board), new PositionChess('d', 7).toPosition());
        Board.SetPiece(new Tower(Color.Black, Board), new PositionChess('e', 7).toPosition());
        Board.SetPiece(new Tower(Color.Black, Board), new PositionChess('e', 8).toPosition());
        Board.SetPiece(new King(Color.Black, Board), new PositionChess('d', 8).toPosition());

    }

}
