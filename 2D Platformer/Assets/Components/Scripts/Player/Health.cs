using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] PlayerHitBox _damageTrigger;

    private ResourceCollector _collector;

    private int _maxHealth = 100;
    private int _currentHealth = 80;
    private int _healthImproving = 15;
    private int _takeDamage = 20;

    private void Awake()
    {
        TryGetComponent(out _collector);
    }

    private void OnEnable()
    {
        _collector.RestoredHealth += RestoreHealth;
        _damageTrigger.ReceivedDamage += TakeDamage;
    }

    private void OnDisable()
    {
        _collector.RestoredHealth -= RestoreHealth;
        _damageTrigger.ReceivedDamage -= TakeDamage;
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

    private void TakeDamage()
    {
        _currentHealth -= _takeDamage;
        Debug.Log($"Здорвье после удара врага {_currentHealth}");
    }
}
