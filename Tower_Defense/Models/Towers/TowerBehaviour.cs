using System.Collections.Generic;
using Tower_Defense.Models.Entities;
using Tower_Defense.Models.Utils;

namespace Tower_Defense.Models.Towers;

public abstract class TowerBehaviour
{
    public abstract Entity? targetedEntity { get; }
    public abstract int Range { get; }

    public abstract Entity? ITargetFirst(List<Entity> entities, Position currentTowerPosition);

    public abstract int RawDamage();

}