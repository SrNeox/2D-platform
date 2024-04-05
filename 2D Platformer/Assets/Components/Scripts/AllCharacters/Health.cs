using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    private int _healthImproving = 15;
    private int _minHealth = 0;

    public int CurrentHealth { get; private set; }
    public int MaxHealth { get; private set; }


    public event Action CharacterDied;
    public event Action HealthChanged;

    private void Awake()
    {
        MaxHealth = 100;
        CurrentHealth = MaxHealth;
    }

    public void Damage(int damage)
    {
        CurrentHealth = Mathf.Clamp(CurrentHealth - damage, _minHealth, MaxHealth);
        HealthChanged?.Invoke();

        if (CurrentHealth <= _minHealth)
        {
            CharacterDied?.Invoke();
        }
    }

    public void Heal()
    {
        CurrentHealth = Mathf.Clamp(CurrentHealth + _healthImproving, 0, MaxHealth);
        HealthChanged?.Invoke();
    }
}
