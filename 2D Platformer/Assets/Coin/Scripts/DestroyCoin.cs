using UnityEngine;

public class DestroyCoin : MonoBehaviour
{
    [SerializeField] private Coin _coin;

    private void OnEnable()
    {
        _coin.CoinDestroy += Destroy;
    }

    private void OnDisable()
    {
        _coin.CoinDestroy -= Destroy;
    }

    private void Destroy()
    {
        Destroy(_coin.gameObject);
    }
}
