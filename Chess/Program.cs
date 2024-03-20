using Chess;
using Chess.ChessBoard;
using Chess.ChessGame;

Board board = new Board(8, 8);
Position p = new Position(1, 1);

board.SetPiece(new King(Color.Black, board), new Position(0, 0));
board.SetPiece(new Tower(Color.Black, board), new Position(1, 3));

Screen.PrintScreen(board);