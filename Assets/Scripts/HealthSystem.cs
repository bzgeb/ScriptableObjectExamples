using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    [SerializeField] IntValue _maxHealth;
    int _currentHealth;

    void Awake()
    {
        _currentHealth = _maxHealth.Value;
    }
}