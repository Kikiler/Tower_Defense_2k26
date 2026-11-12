using Tower_Defense.Models.Utils;

namespace Tower_Defense.Models.Entities;

public interface IMovable
{
    public void MoveTo(Position newPosition);
}