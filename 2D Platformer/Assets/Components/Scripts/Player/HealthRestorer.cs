using UnityEngine;

public class HealthRestorer : MonoBehaviour
{
    private Health _health;
    private ResourceCollector _collector;
    private int _healthImproving = 15;

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
        _health.Heal(_healthImproving);
    }

}
