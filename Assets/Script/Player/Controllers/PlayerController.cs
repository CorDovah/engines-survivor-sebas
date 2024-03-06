using Cysharp.Threading.Tasks;
using Player.views;
using UnityEngine;

namespace Player.controllers
{
    public class PlayerController : IPlayerController
    {
        private IPlayerView _playerView;
        public PlayerController(IPlayerView playerView)
        {
            _playerView = playerView;

            StartMovementCycle().Forget();
        }

        private async UniTask StartMovementCycle()
        {
            var transform = _playerView.Transform;
            var moveSpeed = _playerView.MoveSpeed;

            while(true)
            {
                var direction = _playerView.Direction;
                var horizontal = direction.x;
                var flipX = _playerView.FlipSprite;

                flipX = !(horizontal > 0f) && (horizontal < 0f || flipX);

                _playerView.FlipSprite = flipX;

                _playerView.MoveState =(int) Mathf.Abs(direction.magnitude);
                transform.Translate(direction * moveSpeed * Time.deltaTime);
                await UniTask.NextFrame();
            }
        }
    }
}
