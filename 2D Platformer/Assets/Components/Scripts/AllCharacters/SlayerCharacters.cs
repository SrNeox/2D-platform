using UnityEngine;

[RequireComponent(typeof(Health))]

public class SlayerCharacters : MonoBehaviour
{
    private Health _characterHealth;

    private void Awake()
    {
        _characterHealth = GetComponent<Health>();
    }

    private void OnEnable()
    {
        _characterHealth.CharacterDied += Destroy—haracterDead;
    }

    private void OnDisable()
    {
        _characterHealth.CharacterDied -= Destroy—haracterDead;
    }

    private void Destroy—haracterDead()
    {
        Destroy(gameObject);
    }
}
