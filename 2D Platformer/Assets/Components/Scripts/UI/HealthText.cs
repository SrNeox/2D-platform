using TMPro;
using UnityEngine;

public class HealthText : Signer
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

    override public void ChangeHealth()
    {
        _countHealth.text = $"{HealthPlayer.MaxHealth} - {HealthPlayer.CurrentHealth}";
    }
}
