using UnityEngine;

namespace Player.views
{
    public interface IPlayerView
    {
        Vector2 Direction { get; }

        Transform Transform { get; }

        float MoveSpeed { get; }
        bool FlipSprite { get; set; }

        int MoveState { set; }
    }
}
