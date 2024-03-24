using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Ñoin _coin;
    [SerializeField] private Transform[] _spawns;
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
            var coin = Instantiate(_coin);
            coin.transform.position = _spawns[i].position;

            yield return delay;
        }
    }

    public void Destroy(GameObject gameObject)
    {
        Destroy(gameObject);
    }
}
