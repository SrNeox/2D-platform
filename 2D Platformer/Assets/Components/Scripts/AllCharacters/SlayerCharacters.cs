using UnityEngine;

public class SlayerCharacters : MonoBehaviour
{
    private Health _characterHealth;

    private void Awake()
    {
        TryGetComponent(out _characterHealth);
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
