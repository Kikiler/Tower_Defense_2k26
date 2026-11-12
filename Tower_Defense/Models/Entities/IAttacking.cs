using System.Collections.Generic;

namespace Tower_Defense.Models.Entities;

public interface IAttacking
{
    void Attack();
    void TargetAmong(List<Entity> entities);
    
}