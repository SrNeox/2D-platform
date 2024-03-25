using UnityEngine;

public class Health : MonoBehaviour
{
    private ResourceCollector _collector;

    private int _maxHealth = 100;
    private int _currentHealth = 80;
    private int _healthImproving = 15;

    private void Awake()
    {
        TryGetComponent(out _collector);
    }

    private void OnEnable()
    {
        _collector.RestoredHealth += RestoreHealth;
    }

    private void OnDisable()
    {
        _collector.RestoredHealth -= RestoreHealth;
    }

    private void RestoreHealth()
    {
        if (_currentHealth != _maxHealth) 
        {
            _currentHealth += _healthImproving;

            if(_currentHealth > _maxHealth)
            {
                _currentHealth = _maxHealth;
            }

            Debug.Log($"Здорвье востановлено , текущее здоровье {_currentHealth}");
        }
    }
}
