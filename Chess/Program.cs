using Chess;
using Chess.ChessBoard;
using Chess.ChessGame;
using Chess.Exceptions;
try
{
    Board board = new Board(8, 8);

    // int row = 7;
    // char column = 'c';

    PositionChess pos = new PositionChess('c', 7);
    System.Console.WriteLine(pos);
    System.Console.WriteLine(pos.toPosition());

    Position pos1 = new Position(7, 0);
    Position pos2 = new Position(1, 2);

    King king = new King(Color.Black, board);
    Tower tower = new Tower(Color.White, board);

    board.SetPiece(king, pos1);
    board.SetPiece(tower, pos2);



    Screen.PrintScreen(board);
}
catch (PositionException e)
{
    System.Console.WriteLine(e.Message);
}