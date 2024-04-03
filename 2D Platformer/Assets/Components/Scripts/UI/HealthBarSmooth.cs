using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarSmooth : Signer
{
    [SerializeField] private Image _fillImage;

    private Slider _healthBar;
    private Coroutine _changeHealth;

    private int _rateSmoothChange = 15;

    private void Awake()
    {
        TryGetComponent(out _healthBar);
    }

    void Start()
    {
        _healthBar.maxValue = HealthPlayer.MaxHealth;

        _healthBar.value = HealthPlayer.CurrentHealth;
    }

    override public void ChangeHealth()
    {
        if (_changeHealth != null)
            StopCoroutine(_changeHealth);

        _changeHealth = StartCoroutine(Make�hange());
    }

    private IEnumerator Make�hange()
    {
        while (_healthBar.value != HealthPlayer.CurrentHealth)
        {
            ChangeValue();

            if (_healthBar.value == 0)
                _fillImage.enabled = false;

            yield return null;
        }
    }

    private void ChangeValue()
    {
        _healthBar.value = Mathf.MoveTowards(_healthBar.value, base.HealthPlayer.CurrentHealth, _rateSmoothChange * Time.deltaTime);
    }
}
