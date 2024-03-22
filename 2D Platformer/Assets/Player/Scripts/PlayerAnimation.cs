using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private static readonly int runSpeed = Animator.StringToHash(nameof(runSpeed));

    [SerializeField] private SpriteRenderer _render;
    [SerializeField] private Animator _animator;
    [SerializeField] private StateGround _checkGround;

    public void Flip(float direction)
    {
        _animator.SetFloat(runSpeed, Mathf.Abs(direction));

        _render.flipX = direction < 0;
    }

    public void Jump()
    {
        _animator.SetBool("onGround", _checkGround.OnGround());
    }
}
