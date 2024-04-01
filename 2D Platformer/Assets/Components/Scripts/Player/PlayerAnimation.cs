using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public static readonly int RunSpeed = Animator.StringToHash(nameof(RunSpeed));
    private static readonly int OnGround = Animator.StringToHash(nameof(OnGround));

    [SerializeField] private SpriteRenderer _render;
    [SerializeField] private Animator _animator;
    [SerializeField] private CheckerGround _checkGround;

    public void Run(float direction)
    {
        _animator.SetFloat(RunSpeed, Mathf.Abs(direction));
    }

    public void Jump()
    {
        _animator.SetBool(OnGround, _checkGround.IsOnGround());
    }
}
