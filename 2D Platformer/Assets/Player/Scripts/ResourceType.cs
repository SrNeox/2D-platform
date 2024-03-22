using System;
using UnityEngine;

public class ResourceType : MonoBehaviour
{
    private Ñoin _coin;

    public event Action AddMoney;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.TryGetComponent(out _coin))
        {
            _coin.Destroy();
            AddMoney?.Invoke();
        }
    }
}
