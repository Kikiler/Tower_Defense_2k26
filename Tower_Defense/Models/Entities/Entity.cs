namespace Tower_Defense.Models.Entities;
using Utils;

public abstract class Entity
{
    public int Goldvalue { get; }

    protected Position Position;
    

    protected Entity(Position position, int goldvalue)
    {
        Position = new Position(position.X, position.Y);
        Goldvalue = goldvalue;
    }

    public Position GetPosition()
    {
        return new Position(Position.X, Position.Y);
    }
    
    




}