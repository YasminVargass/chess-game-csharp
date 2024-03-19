namespace Chess.ChessBoard;

public class Piece
{
    public Position Position { get; set; }
    public Color Color { get; private set; }
    public Board Board { get; private set; }
    public int Movements { get; private set; }

    public Piece(Position position, Color color, Board board)
    {
        Position = position;
        Color = color;
        Board = board;
        Movements = 0;
    }


}
