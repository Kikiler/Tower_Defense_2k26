using System.Collections.Generic;
using Tower_Defense.Models.Entities;
using Tower_Defense.Models.Utils;

namespace Tower_Defense.Models.Towers;


public class BaseTower : Tower
{
    private Entity? _target;

    public BaseTower(Position pos, int value, int range, int attackDamage) : base(pos, value, range, attackDamage)
    {
        _target = null;
    }

    public override void Attack()
    {
        if (_target is not null && _target is IDamageable t)
        {
            t.TakeDamage(RawAttackDamage);
        }
    }

    public override void TargetAmong(List<Entity> entities)
    {
        if (_target is not null && IsInRange(_target))
        {
            return;
        }

        Entity? currentPotentialTarget = entities[0];
        foreach (var potentialTarget in entities)
        {
            if (IsInRange(potentialTarget) && potentialTarget.Position.Distance(Position)
                < currentPotentialTarget.Position.Distance(Position))
            {
                currentPotentialTarget = potentialTarget;
            }
        }

        _target = currentPotentialTarget;
    }
}