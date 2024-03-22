using UnityEngine;

public class Wallet : MonoBehaviour
{
    private ResourceType _resourse;

    private int _amountCoint;

    private void Awake()
    {
        TryGetComponent(out _resourse);
    }

    private void OnEnable()
    {
        _resourse.AddMoney += AddMoney;
    }

    private void OnDisable()
    {
        _resourse.AddMoney -= AddMoney;
    }

    private void AddMoney()
    {
        ++_amountCoint;
        Debug.Log(_amountCoint);
    }
}