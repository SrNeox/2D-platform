using UnityEngine;

public class RotateBar : MonoBehaviour
{
    [SerializeField] private PlayerMover _playerMover;

    private void OnEnable()
    {
        _playerMover.RotateBar += Rotate;
    }

    private void OnDisable()
    {
        _playerMover.RotateBar -= Rotate;
    }

    private void Rotate()
    {
        transform.Rotate(Vector2.up, 180);
    }
}
