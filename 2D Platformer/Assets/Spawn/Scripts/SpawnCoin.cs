using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : MonoBehaviour
{
    [SerializeField] private Coin _coin;
    [SerializeField] private Transform[] _spawns;
    [SerializeField] private Wallet _wallet;
    [SerializeField] private int _delaySpawn = 2;


    private void Start()
    {
        StartCoroutine(Spawn()); ;
    }

    private IEnumerator Spawn()
    {
        WaitForSeconds delay = new(_delaySpawn);

        for (int i = 0; i < _spawns.Length; i++)
        {
            Coin coin = Instantiate(_coin);
            coin.SetWallet(_wallet);
            coin.transform.position = _spawns[i].position;
        }

        yield return delay;
    }
}
