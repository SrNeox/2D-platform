using UnityEngine;

public class PlayerAttackerTrigger : MonoBehaviour
{
    private int _damagePlayer = 100;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        collider.TryGetComponent(out Health characterHealth);
        collider.TryGetComponent(out EnemyMover enemyMover);

        if (characterHealth != null && enemyMover != null)
        {
            characterHealth.Damage(_damagePlayer);
        }
    }
}
