using System;
using UnityEngine;

public class ResourceCollector : MonoBehaviour
{
    private Coin _coin;
    private AidKit _aidKit;

    public event Action CoinCollected;
    public event Action PickedUpAidKit;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.TryGetComponent(out _coin))
        {
            _coin.Destroy();
            CoinCollected?.Invoke();
        }
        else if (collider.TryGetComponent(out _aidKit))
        {
            _aidKit.Destroy();
            PickedUpAidKit?.Invoke();
        }
    }
}
