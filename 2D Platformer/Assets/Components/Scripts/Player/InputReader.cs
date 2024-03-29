using UnityEngine;

public class InputReader : MonoBehaviour
{
    private float _horizontalDirection;
    private bool _jump;

    private void Update()
    {
        _horizontalDirection = Input.GetAxis("Horizontal");

        _jump = Input.GetButton("Jump");
    }

    public float SendDirection()
    {
        return _horizontalDirection;
    }

    public bool TakeLeap()
    {
        return _jump;
    }
}
