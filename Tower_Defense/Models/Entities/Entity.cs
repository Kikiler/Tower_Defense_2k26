namespace Tower_Defense.Models.Entities;
using Utils;

public abstract class Entity
{
    public int Goldvalue { get; }
    public abstract int HpBar { get; set; }
    
    public Position Position
    {
        get => new Position(field.X, field.Y);
        set => field = new Position(value.X, value.Y);
    }

    protected Entity(Position position, int goldvalue)
    {
        Position = position;
        Goldvalue = goldvalue;
    }
    




}