using UnityEngine;

public abstract class HealthView : MonoBehaviour
{
    [SerializeField] protected Health HealthPlayer;

    private void OnEnable()
    {
        HealthPlayer.HealthChanged += ChangeHealth;
    }

    private void OnDisable()
    {
        HealthPlayer.HealthChanged -= ChangeHealth;
    }

    public abstract void ChangeHealth();
}
