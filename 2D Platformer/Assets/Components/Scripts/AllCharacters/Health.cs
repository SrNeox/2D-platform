using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    private int _currentHealth;
    private int _maxHealth = 100;
    private int _healthImproving = 15;

    public event Action CharacterDied;

    private void Awake()
    {
        _currentHealth = _maxHealth;
    }

    public void Damage(int damage)
    {
        if (_currentHealth <= 0)
        {
            CharacterDied?.Invoke();
        }

        _currentHealth = Mathf.Clamp(_currentHealth - damage, 0, _maxHealth);

        Debug.Log($"Здорвье после удара врага {_currentHealth}");
    }

    public void Heal()
    {
        _currentHealth = Mathf.Clamp(_currentHealth + _healthImproving, 0, _maxHealth);

        Debug.Log($"Здорвье востановлено , текущее здоровье {_currentHealth}");
    }

    public int ConveyHealthStatus()
    {
        return _currentHealth;
    }
}
