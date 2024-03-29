using UnityEngine;

public class Wallet : MonoBehaviour
{
    private ResourceCollector _collector;

    private int _amountCoint;

    private void Awake()
    {
        TryGetComponent(out _collector);
    }

    private void OnEnable()
    {
        _collector.CoinCollected += AddMoney;
    }

    private void OnDisable()
    {
        _collector.CoinCollected -= AddMoney;
    }

    private void AddMoney()
    {
        ++_amountCoint;
        Debug.Log(_amountCoint);
    }
}