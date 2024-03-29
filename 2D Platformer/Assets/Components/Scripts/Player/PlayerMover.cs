using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    private PlayerAnimation _animation;
    private CheckerGround _checkerGround;
    private Rigidbody2D _rigidBody;
    private InputReader _inputReader;

    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private float _reboundForce;

    private bool _isFaceRight = true;

    private void Awake()
    {
        TryGetComponent(out _animation);
        TryGetComponent(out _checkerGround);
        TryGetComponent(out _rigidBody);
        TryGetComponent(out _inputReader);
    }

    private void FixedUpdate()
    {
        Flip(_inputReader.SendDirection());
        Move(_inputReader.SendDirection());
        Jump(_inputReader.TakeLeap());
    }

    private void Move(float horizontalDirection)
    {
        _animation.Run(horizontalDirection);

        _rigidBody.velocity = new Vector2(horizontalDirection * _speed, _rigidBody.velocity.y);
    }

    private void Jump(bool jump)
    {
        _animation.Jump();

        if (_checkerGround.IsOnGround() && jump)
            _rigidBody.AddForce(new Vector2(_rigidBody.velocity.x, _jumpForce));
    }

    private void Flip(float horizontalDirection)
    {
        if (horizontalDirection < 0 && _isFaceRight || horizontalDirection > 0 && !_isFaceRight)
        {
            _isFaceRight = !_isFaceRight;
            transform.Rotate(Vector2.up, 180);
        }
    }
}