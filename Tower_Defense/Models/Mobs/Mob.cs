using System.Collections.Generic;
using Tower_Defense.Models.Entities;
using Tower_Defense.Models.Utils;

namespace Tower_Defense.Models.Mobs;

public abstract class Mob : Entity, IMovable, IDamageable, IAttacking
{
    public abstract int HpBar { get; set; }
    public Mob(Position position, int value) : base(position, value)
    {
        
    }

    public abstract void MoveTo(Position newPosition);

    public abstract void TakeDamage(int damage);


    public abstract void Attack();

    public abstract void TargetAmong(List<Entity> entities);
}