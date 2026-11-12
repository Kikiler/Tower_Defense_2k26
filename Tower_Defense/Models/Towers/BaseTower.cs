using System.Collections.Generic;
using Tower_Defense.Models.Entities;
using Tower_Defense.Models.Utils;

namespace Tower_Defense.Models.Towers;


public class BaseTower : Tower
{
    private Entity? _target;

    public override int HpBar { get; set; } = 100;
    public override int Range { get; } = 5;
    public int RawAttackDamage { get; }

    public BaseTower(Position pos, int value, int attackDamage) : base(pos, value)
    {
        _target = null;
        RawAttackDamage = attackDamage;
    }

    public override void Attack()
    {
        if (_target is not null && _target is IDamageable t)
        {
            t.TakeDamage(RawAttackDamage);
        }
    }

    public override void TakeDamage(int damage)
    {
        HpBar -= damage;
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
            if (IsInRange(potentialTarget) && potentialTarget.GetPosition().Distance(Position)
                < currentPotentialTarget.GetPosition().Distance(Position))
            {
                currentPotentialTarget = potentialTarget;
            }
        }

        _target = currentPotentialTarget;
    }
}