using System;
using UnityEngine;

public class EnemyHitBox : MonoBehaviour
{
    public event Action ReceivedDamage;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<PlayerMover>() == true)
        {
            ReceivedDamage?.Invoke();
        }
    }
}
