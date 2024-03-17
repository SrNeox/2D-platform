using UnityEngine;

public class SearchPlayer : MonoBehaviour
{
    [SerializeField] private PlayerMover _playerMover;
    [SerializeField] private EnemyMover _enemyMover;
    [SerializeField] private float _speed;

    private void OnTriggerStay2D (Collider2D collider)
    { 
        if(collider.GetComponent<PlayerMover>() == true)
        {
            _enemyMover.enabled = false;
            MoveToPlayer();
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.GetComponent<PlayerMover>() == true)
        {
            _enemyMover.enabled = true;
        }
    }

    private void MoveToPlayer()
    {
        _enemyMover.transform.position = Vector2.MoveTowards(_enemyMover.transform.position,_playerMover.transform.position, _speed * Time.deltaTime);
    }
}
