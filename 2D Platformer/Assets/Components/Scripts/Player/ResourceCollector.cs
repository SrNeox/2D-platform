using System;
using UnityEngine;

public class ResourceCollector : MonoBehaviour
{
    private RaisedResource _resourse;

    public event Action CoinCollected;
    public event Action PickedUpAidKit;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.TryGetComponent(out _resourse) && collider.GetComponent<Coin>())
        {
            _resourse.Destroy();
            CoinCollected?.Invoke();
        }
        else if (collider.TryGetComponent(out _resourse) && collider.GetComponent<AidKit>())
        {
            _resourse.Destroy();
            PickedUpAidKit?.Invoke();
        }
    }
}
