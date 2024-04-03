using TMPro;
using UnityEngine;

public class HealthText : MonoBehaviour
{
    [SerializeField] private Health _healthPlayer;

    private TextMeshProUGUI _countHealth;

    private void Awake()
    {
        _countHealth = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        _healthPlayer.Health—hanged += ChangeHealth;
    }

    private void OnDisable()
    {
        _healthPlayer.Health—hanged -= ChangeHealth;
    }

    private void Start()
    {
        ChangeHealth();
    }

    private void ChangeHealth()
    {
        _countHealth.text = $"{_healthPlayer.MaxHealth} - {_healthPlayer.CurrentHealth}";
    }
}
