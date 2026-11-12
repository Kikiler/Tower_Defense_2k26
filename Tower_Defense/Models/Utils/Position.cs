using System;
using System.ComponentModel.Design;
using Avalonia;

namespace Tower_Defense.Models.Utils;

public class Position
{
    public int X { get; set; }
    public int Y { get; set; }

    public Position(int x, int y)
    {
        if (x < 0 || y < 0)
            throw new Exception($"negative values not accepted for positions [x, y] = [{x}, {y}]");
        X = x;
        Y = y;
    }

    double Distance(Position otherPos)
    {
        if (otherPos is null)
            throw new NullReferenceException("the other position is null");
        return Math.Sqrt(Math.Pow(X - otherPos.X, 2) + Math.Pow(Y - otherPos.Y, 2));
    }

    public override bool Equals(object? obj)
    {
        if(obj is null)
            throw new NullReferenceException("the other obj is null");
        if (obj is Position pos)
            return pos.X == X && pos.Y == Y;
        return false;
    }
}