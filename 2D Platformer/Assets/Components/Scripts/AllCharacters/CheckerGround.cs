using UnityEngine;

public class CheckerGround : MonoBehaviour
{
    [SerializeField] private LayerMask _layerMask;
    [SerializeField] private Vector2 _boxSize;
    [SerializeField] private float _castDistanse;

    public bool IsOnGround()
    {
        return Physics2D.BoxCast(transform.position, _boxSize, 0, Vector2.down, _castDistanse, _layerMask);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position - Vector3.up * _castDistanse, _boxSize);
    }
}
