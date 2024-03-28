using UnityEngine;

public class HealthEnemy : MonoBehaviour
{
    [SerializeField] private EnemyHitBox _hitBox;

    private EnemyMover _mover;
    private Animator _animator;

    private Rigidbody2D _rigBody;
    private Vector2 _transformAfterDead = new(1.5f, 0.5f);

    private void Awake()
    {
        TryGetComponent(out _mover);
        TryGetComponent(out _rigBody);
        TryGetComponent(out _animator);
    }

    private void OnEnable()
    {
        _hitBox.ReceivedDamage += TakeDamage;
    }

    private void OnDisable()
    {
        _hitBox.ReceivedDamage -= TakeDamage;
    }

    private void TakeDamage()
    {
        gameObject.SetActive(false);
    }
}
