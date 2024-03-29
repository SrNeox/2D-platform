using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthRestorer : MonoBehaviour
{
    private Health _health;
    private ResourceCollector _collector;

    private void Awake()
    {
        TryGetComponent(out _health);
        TryGetComponent(out _collector);
    }

    private void OnEnable()
    {
        _collector.PickedUpAidKit += Restore;
    }

    private void OnDisable()
    {
        _collector.PickedUpAidKit -= Restore;
    }

    private void Restore()
    {
        _health.RestoreHealth();
    }

}
