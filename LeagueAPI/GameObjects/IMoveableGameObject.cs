using LeagueAPI.MovementSystem;
using System.Collections.Generic;
using System.Numerics;

namespace LeagueAPI.GameObjects
{
    /// <summary>
    /// interface for moveable objects (minions/champions)
    /// </summary>
    interface IMoveableGameObject : IGameObject
    {
        List<Vector2> Waypoints { get; }
        int CurWaypoint { get; }

        void SetWaypoints(List<Vector2> newWaypoints);
        void Move(float diff);
        void Move(float diff, Vector2 to);
        bool IsMovementUpdated();
        void ClearMovementUpdated();
        float GetMoveSpeed();

        // maybe move these to IDashable
        bool IsDashing { get; }
        void DashToTarget(Target t, float dashSpeed, float followTargetMaxDistance, float backDistance, float travelTime);
        void SetDashingState(bool state);
    }
}
