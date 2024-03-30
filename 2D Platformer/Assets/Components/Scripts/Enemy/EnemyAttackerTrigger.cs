using UnityEngine;

public class EnemyAttackerTrigger : MonoBehaviour
{
    private int _damageEnemy = 25;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        collider.TryGetComponent(out Health characterHealth);
        collider.TryGetComponent(out PlayerMover playerMover);

        if (characterHealth != null && playerMover != null)
        {
            characterHealth.Damage(_damageEnemy);
        }
    }
}
