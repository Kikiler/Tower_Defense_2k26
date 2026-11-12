using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using Tower_Defense.Models.Utils;

namespace Tower_Defense.Models.Entities;

public abstract class AttackingEntity : Entity, Attacking
{
    public int Range { get; set; }

    protected AttackingEntity(Position position, int value, int range) : base(position, value)
    {
        Range = range;
    }

    public abstract void ITarget(List<Entity> entities);
    public abstract void Attack();

    public bool IsInRange(Entity otherEntity) => otherEntity.Position.Distance(Position) < Range;

}