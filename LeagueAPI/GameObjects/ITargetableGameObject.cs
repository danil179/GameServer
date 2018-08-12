using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueAPI.GameObjects
{
    /// <summary>
    /// Interface for attackable objects (wards/champions/turrets/minions)
    /// </summary>
    public interface IAttackableGameObject : IGameObject
    {
        bool IsSimpleTarget { get; }
    }
}
