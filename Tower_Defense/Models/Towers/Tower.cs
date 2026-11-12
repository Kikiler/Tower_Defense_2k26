using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using Tower_Defense.Models.Entities;
using Tower_Defense.Models.Utils;

namespace Tower_Defense.Models.Towers;

public abstract class Tower : Entity, IAttacking, IDamageable
{

    public abstract int Range { get;}
    public abstract int HpBar { get; set; }


     protected Tower(Position pos, int value) :
        base(pos, value){}

    public abstract void TakeDamage(int damage);

    public abstract void Attack();

    public abstract void TargetAmong(List<Entity> entities);
    
    protected bool IsInRange(Entity otherEntity) => otherEntity.GetPosition().Distance(Position) < Range;
}