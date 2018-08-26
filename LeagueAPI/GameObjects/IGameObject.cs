using System.Collections.Generic;
using System.Numerics;
using LeagueAPI.MovementSystem;
using LeagueAPI.Common.Definitions;

namespace LeagueAPI.GameObjects
{
    public interface IGameObject
    {
        // REVIEW: what are these?
        //int AttackerCount { get; }
        //void DecrementAttackerCount();
        //void IncrementAttackerCount();      
        uint NetId { get; }
        Target Target { get; set; }
        TeamId Team { get; }

        // consider moving this to IVisionGameObject
        float VisionRadius { get; }

        
        float GetZ(); // change with GetPosition
        bool IsToRemove();
        bool IsVisibleByTeam(TeamId team);
        void OnAdded();
        void OnRemoved();
        void SetPosition(Vector2 vec);
        void SetPosition(float x, float y);
        void SetTeam(TeamId team);
        void SetToRemove();
        void SetVisibleByTeam(TeamId team, bool visible);
        
        void Update(float diff);
    }
}