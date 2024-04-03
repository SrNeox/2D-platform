using UnityEngine;
using UnityEngine.UI;

public class HealthBar : Signer
{
    [SerializeField] private Image _fillImage;

    private Slider _healthBar;

    private void Awake()
    {
        TryGetComponent(out _healthBar);
    }

    private void Start()
    {
        _healthBar.maxValue = HealthPlayer.MaxHealth;

        _healthBar.value = HealthPlayer.CurrentHealth;
    }

    override public void ChangeHealth()
    {
        if (_healthBar.value == 0)
            _fillImage.enabled = false;

        _healthBar.value = HealthPlayer.CurrentHealth;
    }
}
