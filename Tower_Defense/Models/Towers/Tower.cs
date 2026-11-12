using System;
using System.Collections.Generic;
using System.Linq;
using Tower_Defense.Models.Entities;
using Tower_Defense.Models.Utils;

namespace Tower_Defense.Models.Towers;

public abstract class Tower : AttackingEntity
{

    public override int HpBar { get; set; } = 100;
    public int RawAttackDamage { get; }

    public Tower(Position pos, int value, int range,  int attackDamage) :
    base(pos, value, range)
    {
        RawAttackDamage = attackDamage;
    }

    public override void TakeDamage(int damage)
    {
        HpBar -= damage;
    }
    
}