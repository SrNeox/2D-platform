using System;
using UnityEngine;

public class EnemyHitBox : MonoBehaviour
{
    public event Action ReceivedDamage;

    private PlayerMover _player;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.TryGetComponent(out _player))
        {
            ReceivedDamage?.Invoke();
        }
    }
}
