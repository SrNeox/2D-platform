using System;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private float _reboundForce;

    private PlayerAnimation _animation;
    private CheckerGround _checkerGround;
    private Rigidbody2D _rigidBody;
    private InputReader _inputReader;

    public bool IsFaceRight { get; private set; }

    public event Action RotateBar;

    private void Awake()
    {
        TryGetComponent(out _animation);
        TryGetComponent(out _checkerGround);
        TryGetComponent(out _rigidBody);
        TryGetComponent(out _inputReader);
    }

    private void FixedUpdate()
    {
        Flip();
        Move();
        Jump();
    }

    private void Move()
    {
        _animation.Run(_inputReader.HorizontalDirection);

        _rigidBody.velocity = new Vector2(_inputReader.HorizontalDirection * _speed, _rigidBody.velocity.y);
    }

    private void Jump()
    {
        if (_checkerGround.IsOnGround() && _inputReader.IsJump)
        {
            _rigidBody.AddForce(new Vector2(_rigidBody.velocity.x, _jumpForce));
        }

        _animation.Jump();
    }

    public void Flip()
    {
        if (_inputReader.HorizontalDirection > 0 && IsFaceRight || _inputReader.HorizontalDirection < 0 && !IsFaceRight)
        {
            IsFaceRight = !IsFaceRight;
            transform.Rotate(Vector2.up, 180);
            RotateBar?.Invoke();
        }
    }
}