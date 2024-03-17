using System;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private Wallet _wallet;

    public event Action CoinDestroy;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.GetComponent<PlayerMover>() == true)
        {
            _wallet.AddMoney();
            CoinDestroy?.Invoke();
        }
    }

    public void SetWallet(Wallet wallet)
    {
        _wallet = wallet;
    }
}
