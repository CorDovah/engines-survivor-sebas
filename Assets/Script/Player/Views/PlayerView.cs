using Player.views;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using Utils.Bindings;

public class PlayerView : MonoBehaviour, IPlayerView
{
    [SerializeField] private float _MovementSpeed;
    [SerializeField] private PlayerInput _PlayerInput;
    [SerializeField] private SpriteRenderer _SpriteRenderer;
    [SerializeField] private Animator _animator;
    private Vector2 _direction;
    [SerializeField] private IntBinding _moveBinding;

    public Vector2 Direction => _direction;
    public Transform Transform => transform;
    public float MoveSpeed => _MovementSpeed;
    public bool FlipSprite { get => _SpriteRenderer.flipX; set => _SpriteRenderer.flipX = value; }
    public int MoveState { set => _moveBinding.Value = value; }

    public void SetDirection(InputAction.CallbackContext ctx)
    {
        _direction = ctx.ReadValue<Vector2>();
    }
    private void TranslateAllDirections(Vector2 axis) => transform.Translate(axis * Time.deltaTime * _MovementSpeed);
}