using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarSmooth : MonoBehaviour
{
    [SerializeField] private Health _healthPlayer;
    [SerializeField] private Image _fillImage;

    private Slider _healthBar;
    private Coroutine _changeHealth;

    private int _rateSmoothChange = 15;

    private void Awake()
    {
        _healthBar = GetComponent<Slider>();
    }

    private void OnEnable()
    {
        _healthPlayer.Health—hanged += StartChangeHealth;
    }

    private void OnDisable()
    {
        _healthPlayer.Health—hanged -= StartChangeHealth;
    }

    void Start()
    {
        _healthBar.maxValue = _healthPlayer.MaxHealth;

        _healthBar.value = _healthPlayer.CurrentHealth;

    }

    private void StartChangeHealth()
    {
        if (_changeHealth != null)
            StopCoroutine(_changeHealth);
        
        _changeHealth = StartCoroutine(Make—hange());
    }

    private IEnumerator Make—hange()
    {
        while (_healthBar.value != _healthPlayer.CurrentHealth)
        {
            ChangeHealth();

            if (_healthBar.value == 0)
                _fillImage.enabled = false;

            yield return null;
        }

    }

    private void ChangeHealth()
    {
        _healthBar.value = Mathf.MoveTowards(_healthBar.value, _healthPlayer.CurrentHealth, _rateSmoothChange * Time.deltaTime);
    }
}
