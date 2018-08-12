using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueAPI.GameObjects
{
    /// <summary>
    /// Interface for collidable (analyze collisons) objects (turrets/wards/some projectiles)
    /// </summary>
    interface ICollideableGameObject : IGameObject
    {
        bool IsSolid { get;}
        bool IsCollidingWith(IGameObject o);
        float CollisionRadius { get; set; }
        void OnCollision(IGameObject collider);
    }
}
