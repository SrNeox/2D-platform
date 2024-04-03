using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    private int _healthImproving = 15;

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
        if (CurrentHealth <= 0)
        {
            CharacterDied?.Invoke();
        }

        CurrentHealth = Mathf.Clamp(CurrentHealth - damage, 0, MaxHealth);
        HealthChanged?.Invoke();
    }

    public void Heal()
    {
        CurrentHealth = Mathf.Clamp(CurrentHealth + _healthImproving, 0, MaxHealth);
        HealthChanged?.Invoke();
    }   
}
