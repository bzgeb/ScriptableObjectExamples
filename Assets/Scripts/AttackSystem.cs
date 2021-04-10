using UnityEngine;

public class AttackSystem : MonoBehaviour
{
    [SerializeField] IntValue _attackDamage;
    int Damage => _attackDamage.Value;

    public void Attack(HealthSystem healthSystem)
    {
        healthSystem.TakeDamage(Damage);
    }
}
