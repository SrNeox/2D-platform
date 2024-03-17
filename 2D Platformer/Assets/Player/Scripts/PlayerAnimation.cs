using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _render;
    [SerializeField] private Animator _animator;
    [SerializeField] private CheckGround _checkGround;

    public void Flip(float direction)
    {
        _animator.SetFloat("runSpeed", Mathf.Abs(direction));

        if (direction < 0)
            _render.flipX = true;
        else
            _render.flipX = false;
    }

    public void Jump()
    {
        if (_checkGround.OnGround())
            _animator.SetBool("onGround", true);
        else
            _animator.SetBool("onGround", false);
    }
}
