using UnityEngine;

public abstract class HealthView : MonoBehaviour
{
    [SerializeField] protected Health HealthCharacter;

    private void OnEnable()
    {
        HealthCharacter.HealthChanged += ChangeHealth;
    }

    private void OnDisable()
    {
        HealthCharacter.HealthChanged -= ChangeHealth;
    }

    public abstract void ChangeHealth();
}
