namespace Tower_Defense.Models.Entities;
using Utils;

public abstract class Entity
{
    public abstract int Goldvalue { get; }
    public abstract int HpBar { get;}
    
    public abstract Position Pos
    {
        get;
        set;
    }
    

    public abstract void TakeDamage(int damage);




}