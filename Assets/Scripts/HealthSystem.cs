using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    [SerializeField] IntValue _maxHealth;
    int _currentHealth;

    void Awake()
    {
        _currentHealth = _maxHealth.Value;
    }

    public void TakeDamage(int damage)
    {
        _currentHealth -= damage;
        _currentHealth = Mathf.Max(0, _currentHealth);
    }
}