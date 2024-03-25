using System;
using UnityEngine;

public class ResourceCollector : MonoBehaviour
{
    private Coin _coin;
    private AidKit _aidKit;

    public event Action ÑoinCollected;
    public event Action RestoredHealth;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.TryGetComponent<Coin>(out _coin))
        {
            _coin.Destroy();
            ÑoinCollected?.Invoke();
        }
        else if (collider.TryGetComponent(out _aidKit))
        {
            _aidKit.Destroy();
            RestoredHealth?.Invoke();
        }
    }
}
