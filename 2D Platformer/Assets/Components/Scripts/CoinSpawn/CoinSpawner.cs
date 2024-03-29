using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Coin _coin;
    [SerializeField] private Transform[] _spawns;

    private void Start()
    {
        Spawn();
    }

    private void Spawn()
    {
        for (int i = 0; i < _spawns.Length; i++)
        {
            var coin = Instantiate(_coin);
            coin.transform.position = _spawns[i].position;
        }
    }
}
