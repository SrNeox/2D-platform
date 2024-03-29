using UnityEngine;

public class PlayerFinder : MonoBehaviour
{
    private PlayerMover _player;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<PlayerMover>())
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

    public PlayerMover FindPlayer()
    {
        return _player;
    }
}
