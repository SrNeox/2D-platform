using TMPro;
using UnityEngine;

public class HealthText : HealthView
{
    private TextMeshProUGUI _countHealth;

    private void Awake()
    {
        TryGetComponent(out _countHealth);
    }

    private void Start()
    {
        ChangeHealth();
    }

    public override void ChangeHealth()
    {
        _countHealth.text = $"{HealthCharacter.MaxHealth} - {HealthCharacter.CurrentHealth}";
    }
}
