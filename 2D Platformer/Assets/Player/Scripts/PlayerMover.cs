using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private PlayerAnimation _animation;
    [SerializeField] private StateGround _checkGround;
    [SerializeField] private Rigidbody2D _rigBody;

    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private float _reboundForce;

    private Vector2 _direction;

    void FixedUpdate()
    {
        Move();
        Jump();
    }

    private void Move()
    {
        _direction.x = Input.GetAxis("Horizontal");

        _animation.Flip(_direction.x);

        _rigBody.velocity = new Vector2(_direction.x * _speed, _rigBody.velocity.y);
    }

    private void Jump()
    {
        _animation.Jump();

        if (_checkGround.OnGround() && Input.GetButton("Jump"))
            _rigBody.AddForce(new Vector2(_rigBody.velocity.x , _jumpForce));
    }
}