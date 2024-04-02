using System.Collections;
using UnityEngine;

public class SpawnerResourse : MonoBehaviour
{
    [SerializeField] private RaisedResource _resoursePrefab;
    [SerializeField] private Transform[] _spawns;

    private void Start()
    {
        Spawn();
    }

    private void Spawn()
    {
        for (int i = 0; i < _spawns.Length; i++)
        {
            RaisedResource coin = Instantiate(_resoursePrefab);
            coin.transform.position = _spawns[i].position;
        }
    }
}
