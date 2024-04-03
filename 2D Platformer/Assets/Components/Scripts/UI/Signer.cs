using UnityEngine;

public abstract class Signer : MonoBehaviour
{
    [SerializeField] protected Health HealthPlayer;

    private void OnEnable()
    {
        HealthPlayer.Health—hanged += ChangeHealth;
    }

    private void OnDisable()
    {
        HealthPlayer.Health—hanged -= ChangeHealth;
    }

    public abstract void ChangeHealth();
}
