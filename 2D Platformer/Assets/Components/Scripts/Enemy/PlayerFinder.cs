using UnityEngine;

public class PlayerFinder : MonoBehaviour
{
    public PlayerMover _player { get; private set; }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<EnemyMover>())
        {
            _player = collider.GetComponent<PlayerMover>();
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.GetComponent<PlayerMover>())
        {
            _player = null;
        }
    }
}
