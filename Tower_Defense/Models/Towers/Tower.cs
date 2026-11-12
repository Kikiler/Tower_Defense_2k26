using System;
using Tower_Defense.Models.Entities;
using Tower_Defense.Models.Utils;

namespace Tower_Defense.Models.Towers;

public class Tower : Entity, Attacking
{
    public override Position Pos
    {
        get => new Position(field.X, field.Y);
        set => field = new Position(value.X, value.Y);
    }
    
    public TowerBehaviour Behaviour { get; set; }

    private int _goldvalue;
    public override int Goldvalue => _goldvalue;
    public override int HpBar { get;}


    public Tower(Position pos, int hpBar, int value, TowerBehaviour behavior)
    {
        _goldvalue = value;
        Pos = new Position(pos.X, pos.Y);
        if (0 < hpBar)
            throw new Exception("hpbar must be greater than 0 at start");
        HpBar = hpBar;
        Behaviour = behavior;
    }

    public override void TakeDamage(int damage)
    {
        _goldvalue -= damage;
    }

    public void Attack(Entity otherEntity)
    {
        otherEntity.TakeDamage(Behaviour.RawDamage());
    }
}