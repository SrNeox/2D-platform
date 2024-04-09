using System.Collections;
using UnityEngine;

public class LifeSteal : MonoBehaviour
{
    [SerializeField] private int _timeSteal = 6;
    [SerializeField] private int _lifeStealInSecond = 15;
    [SerializeField] private float _radius;
    [SerializeField] private LayerMask _layerEnemy;

    private Health _playerHealth;

    private Coroutine _stealHealth;
    private Collider2D _collider;

    private void Awake()
    {
        TryGetComponent(out _playerHealth);
    }

    public void StartStealHealth()
    {
        if (_stealHealth != null)
            StopCoroutine(_stealHealth);

        _stealHealth = StartCoroutine(StealHealth());
    }

    private IEnumerator StealHealth()
    {
        WaitForSeconds delay = new(1);

        for (int i = 0; i < _timeSteal; i++)
        {
            _collider = Physics2D.OverlapCircle(transform.position, _radius, _layerEnemy) ;

            if(_collider == null)
            {
                yield break;
            }
            else if (_collider.TryGetComponent(out Health enemyHealth) == true )
            {
                enemyHealth.Damage(_lifeStealInSecond);
                _playerHealth.Heal(_lifeStealInSecond);
            }

            yield return delay;
        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, _radius);
    }
}
