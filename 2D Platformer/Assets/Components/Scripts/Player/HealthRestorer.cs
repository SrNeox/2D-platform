using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthRestorer : MonoBehaviour
{
    private Health _health;
    private ResourceCollector _collector;

    private void Awake()
    {
        _health = GetComponent<Health>();
        _collector = GetComponent<ResourceCollector>();
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
        _health.Heal();
    }

}
