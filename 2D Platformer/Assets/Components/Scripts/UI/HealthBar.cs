using UnityEngine;
using UnityEngine.UI;

public class HealthBar : HealthView
{
    [SerializeField] private Image _fillImage;

    private Slider _healthBar;

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
        if (_healthBar.value == 0)
            _fillImage.enabled = false;

        _healthBar.value = HealthCharacter.CurrentHealth;
    }
}
