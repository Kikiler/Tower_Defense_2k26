using System.Collections.Generic;
using Tower_Defense.Models.Entities;
using Tower_Defense.Models.Utils;

namespace Tower_Defense.Models.Towers;

public abstract class Tower : Entity, IAttacking, IDamageable
{

    public int Range { get; set; }
    public override int HpBar { get; set; } = 100;
    public int RawAttackDamage { get; }

    public Tower(Position pos, int value, int range,  int attackDamage) :
    base(pos, value)
    {
        RawAttackDamage = attackDamage;
        Range = range;
    }

    public void TakeDamage(int damage)
    {
        HpBar -= damage;
    }

    public abstract void Attack();

    public abstract void TargetAmong(List<Entity> entities);
    
    protected bool IsInRange(Entity otherEntity) => otherEntity.Position.Distance(Position) < Range;
}