using System.Collections.Generic;

namespace Tower_Defense.Models.Entities;

public interface Attacking
{
    void Attack();
    void ITarget(List<Entity> entities);
}