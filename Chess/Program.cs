using Chess;
using Chess.ChessBoard;
using Chess.ChessGame;
using Chess.Exceptions;
try
{
    Board board = new Board(8, 8);


    Position pos = new Position(1, 1);
    Position pos2 = new Position(1, 5);

    King king = new King(Color.Black, board);
    Tower tower = new Tower(Color.White, board);

    board.SetPiece(king, pos);
    board.SetPiece(tower, pos2);



    Screen.PrintScreen(board);
}
catch (PositionException e)
{
    System.Console.WriteLine(e.Message);
}