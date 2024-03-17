using UnityEngine;

public class Wallet : MonoBehaviour
{
    [SerializeField] private Coin _coin;

    private int _amountCoint;

    public void AddMoney()
    {
        ++_amountCoint;
        Debug.Log(_amountCoint);
    }
}