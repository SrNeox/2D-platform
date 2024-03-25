using System;
using Unity.VisualScripting;
using UnityEngine;

public class ResourceCollector : MonoBehaviour
{
    private Coin _coin;

    public event Action �oinCollected;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.TryGetComponent(out _coin))
        {
            _coin.IsDestroyed();
            �oinCollected?.Invoke();
        }
    }
}
