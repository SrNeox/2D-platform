using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private Transform[] _movePoints;
    [SerializeField]private SearchPlayer _searchPlayer;
    [SerializeField] private float _speed;

    private int _currentPoint = 0;
    private float _minDistanceContacts = 0.5f;

    private void FixedUpdate()
    {
        if (_searchPlayer.SetPositionPlayer() != null)
            MoveToPlayer(_searchPlayer.SetPositionPlayer());
        else
            MoveToPoint();
    }

    private void MoveToPoint()
    {
        if (Vector2.Distance(transform.position, _movePoints[_currentPoint].position) < _minDistanceContacts)
        {
            _currentPoint = ++_currentPoint % _movePoints.Length;
        }

        transform.position = Vector3.MoveTowards(transform.position, _movePoints[_currentPoint].position, _speed * Time.deltaTime);
    }

    private void MoveToPlayer(PlayerMover player)
    {
        transform.position = Vector2.MoveTowards
            (transform.position, player.transform.position, _speed * Time.deltaTime);
    }
}
