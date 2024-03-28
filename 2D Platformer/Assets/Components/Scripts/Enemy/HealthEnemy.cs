using UnityEngine;

public class HealthEnemy : MonoBehaviour
{
    [SerializeField] private EnemyHitBox _hitBox;

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
