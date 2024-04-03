using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Health _healthPlayer;
    [SerializeField] private Image _fillImage;

    private Slider _healthBar;

    private void Awake()
    {
        _healthBar = GetComponent<Slider>();
    }

    private void OnEnable()
    {
        _healthPlayer.Health—hanged += ChangeHealth;
    }

    private void OnDisable()
    {
        _healthPlayer.Health—hanged -= ChangeHealth;
    }

    void Start()
    {
        _healthBar.maxValue = _healthPlayer.MaxHealth;

        _healthBar.value = _healthPlayer.CurrentHealth;
    }


    private void ChangeHealth()
    {
        if (_healthBar.value == 0)
            _fillImage.enabled = false;

        _healthBar.value = _healthPlayer.CurrentHealth;
    }
}
