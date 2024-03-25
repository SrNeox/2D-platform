using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    private static float _horizontalDirection;
    private static bool _jump;

    [SerializeField] private PlayerAnimation _animation;
    [SerializeField] private StateGround _checkGround;
    [SerializeField] private Rigidbody2D _rigBody;

    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private float _reboundForce;

    private bool _isFaceRight = true;

    private void Update()
    {
        _horizontalDirection = Input.GetAxis("Horizontal");

        _jump = Input.GetButton("Jump");
    }

    void FixedUpdate()
    {
        Flip();
        Move();
        Jump();
    }

    private void Move()
    {
        _animation.Run(_horizontalDirection);

        _rigBody.velocity = new Vector2(_horizontalDirection * _speed, _rigBody.velocity.y);
    }

    private void Jump()
    {
        _animation.Jump();

        if (_checkGround.IsOnGround() && _jump)
            _rigBody.AddForce(new Vector2(_rigBody.velocity.x, _jumpForce));
    }

    private void Flip()
    {
        if (_horizontalDirection < 0 && _isFaceRight || _horizontalDirection > 0 && !_isFaceRight)
        {
            _isFaceRight = !_isFaceRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}