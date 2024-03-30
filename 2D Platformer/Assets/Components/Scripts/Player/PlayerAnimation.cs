using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private int runSpeed = Animator.StringToHash(nameof(runSpeed));
    private int onGround = Animator.StringToHash(nameof(onGround));

    [SerializeField] private SpriteRenderer _render;
    [SerializeField] private Animator _animator;
    [SerializeField] private CheckerGround _checkGround;

    public void Run(float direction)
    {
        _animator.SetFloat(runSpeed, Mathf.Abs(direction));
    }

    public void Jump()
    {
        _animator.SetBool(onGround, _checkGround.IsOnGround());
    }
}
