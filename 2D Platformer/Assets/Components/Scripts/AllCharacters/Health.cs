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

    public void TakeDamage(int damage)
    {
        if (_currentHealth > damage)
        {
            _currentHealth -= damage;
            Debug.Log($"Здорвье после удара врага {_currentHealth}");
        }
        else
        {
            CharacterDied?.Invoke();
        }
    }

    public void RestoreHealth()
    {
        if (_currentHealth != _maxHealth)
        {
            _currentHealth += _healthImproving;

            if (_currentHealth > _maxHealth)
            {
                _currentHealth = _maxHealth;
            }

            Debug.Log($"Здорвье востановлено , текущее здоровье {_currentHealth}");
        }
    }

    public int ConveyHealthStatus()
    {
        return _currentHealth;
    }
}
