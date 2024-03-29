﻿namespace Chess.ChessBoard;

public class Position
{
    public int Row { get; private set; }
    public int Column { get; private set; }


    public Position(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public override string ToString()
    {
        return
        Row +
        ", " +
        Column;
    }

}
