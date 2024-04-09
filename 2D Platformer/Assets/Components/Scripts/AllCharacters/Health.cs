using System;
using System.ComponentModel;
using Unity.Collections;
using UnityEngine;

public class Health : MonoBehaviour
{
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

    public void Heal(int healthImproving)
    {
        CurrentHealth = Mathf.Clamp(CurrentHealth + healthImproving, 0, MaxHealth);
        HealthChanged?.Invoke();
    }
}
