using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    [SerializeField] private LayerMask _layerMask;
    [SerializeField] private Vector2 _boxSize;
    [SerializeField] private float _castDistanse;

    public bool OnGround()
    {
        if (Physics2D.BoxCast(transform.position, _boxSize, 0, Vector2.down, _castDistanse, _layerMask))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position - Vector3.up * _castDistanse, _boxSize);
    }
}
