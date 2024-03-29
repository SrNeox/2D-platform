using UnityEngine;

public class AttackerTrigger : MonoBehaviour
{
    private Health _caracterHealth;

    private int _damagePlayer = 100;
    private int _damageEnemy = 25;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.TryGetComponent(out _caracterHealth) && collider.GetComponent<PlayerMover>())
        {
            _caracterHealth.Damage(_damageEnemy);
        }
        else if (collider.TryGetComponent(out _caracterHealth) && collider.GetComponent<EnemyMover>())
        {
            _caracterHealth.Damage(_damagePlayer);
        }
    }
}
