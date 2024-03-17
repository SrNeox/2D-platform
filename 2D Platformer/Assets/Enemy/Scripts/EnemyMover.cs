using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private Transform[] _movePoints;
    [SerializeField] private float _speed;

    private int _currentPoint = 0;

    private void Update()
    {
        MoveToPoint();
    }

    private void MoveToPoint()
    {
        if (Vector2.Distance(transform.position, _movePoints[_currentPoint].position) < 0.5f)
        {
            _currentPoint = (++_currentPoint) % _movePoints.Length;
        }

        transform.position = Vector3.MoveTowards(transform.position, _movePoints[_currentPoint].position, _speed * Time.deltaTime);
    }
}
