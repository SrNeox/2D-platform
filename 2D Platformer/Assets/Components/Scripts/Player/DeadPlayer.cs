using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadPlayer : MonoBehaviour
{
    private Health _playerHealth;

    private void Awake()
    {
        TryGetComponent(out _playerHealth);
    }

    private void OnEnable()
    {
        _playerHealth.PlayerDied += Dead;
    }

    private void OnDisable()
    {
        _playerHealth.PlayerDied -= Dead;
    }
    private void Dead()
    {
        Destroy(gameObject);
    }
}
