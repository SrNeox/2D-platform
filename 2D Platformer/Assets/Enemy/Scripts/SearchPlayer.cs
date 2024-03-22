using UnityEngine;

public class SearchPlayer : MonoBehaviour
{
    [SerializeField] private EnemyMover _enemyMover;
    [SerializeField] private float _speed;

    private PlayerMover _player;

    private void Update()
    {
        if (_player != null)
            MoveToPlayer();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.TryGetComponent(out _player))
        {
            _enemyMover.enabled = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.GetComponent<PlayerMover>())
        {
            _enemyMover.enabled = true;
            _player = null;
        }
    }

    private void MoveToPlayer()
    {
        _enemyMover.transform.position = Vector2.MoveTowards
            (_enemyMover.transform.position, _player.transform.position, _speed * Time.deltaTime);
    }
}
