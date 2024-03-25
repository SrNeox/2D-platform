using UnityEngine;

public class Wallet : MonoBehaviour
{
    private ResourceCollector _resourse;

    private int _amountCoint;

    private void Awake()
    {
        TryGetComponent(out _resourse);
    }

    private void OnEnable()
    {
        _resourse.�oinCollected += AddMoney;
    }

    private void OnDisable()
    {
        _resourse.�oinCollected -= AddMoney;
    }

    private void AddMoney()
    {
        ++_amountCoint;
        Debug.Log(_amountCoint);
    }
}