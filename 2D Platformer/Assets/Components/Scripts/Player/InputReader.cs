using UnityEngine;

public class InputReader : MonoBehaviour
{
    private const string _horizontalDirection = "Horizontal";
    private const string _jump = "Jump";

    public float HorizontalDirection {  get; private set; }
    public bool IsJump {  get; private set; }

    private void Update()
    {
        HorizontalDirection = Input.GetAxis(_horizontalDirection);

        IsJump = Input.GetButton(_jump);
    }
}
