using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarSmooth : HealthView
{
    [SerializeField] private Image _fillImage;

    private Slider _healthBar;
    private Coroutine _changeHealth;
    private int _rateSmoothChange = 15;

    private void Awake()
    {
        TryGetComponent(out _healthBar);
    }

    private void Start()
    {
        _healthBar.maxValue = HealthCharacter.MaxHealth;

        _healthBar.value = HealthCharacter.CurrentHealth;
    }

    public override void ChangeHealth()
    {
        if (_changeHealth != null)
            StopCoroutine(_changeHealth);

        _changeHealth = StartCoroutine(Make—hange());
    }

    private IEnumerator Make—hange()
    {
        while (_healthBar.value != HealthCharacter.CurrentHealth)
        {
            ChangeValue();

            if (_healthBar.value == 0)
                _fillImage.enabled = false;

            yield return null;
        }
    }

    private void ChangeValue()
    {
        _healthBar.value = Mathf.MoveTowards(_healthBar.value, HealthCharacter.CurrentHealth, _rateSmoothChange * Time.deltaTime);
    }
}
