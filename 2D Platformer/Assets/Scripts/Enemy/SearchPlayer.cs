using UnityEngine;

public class SearchPlayer : MonoBehaviour
{
    public PlayerMover _player;   

    private void OnTriggerEnter2D(Collider2D collider)
    {
        collider.TryGetComponent(out _player);
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.TryGetComponent(out _player))
        {
            _player = null;
        }
    }
}
