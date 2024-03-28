using System;
using UnityEngine;

public class PlayerHitBox : MonoBehaviour
{
    public event Action ReceivedDamage;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<EnemyMover>() == true)
        {
            ReceivedDamage?.Invoke();
        }
    }
}
