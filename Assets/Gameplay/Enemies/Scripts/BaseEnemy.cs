using UnityEngine;

namespace Assets.Gameplay.Enemies.Scripts
{
  public class EnemyStats
  {
    public float MaxHealth { get; }
    public float CurrentHealth { get; private set; }

    public EnemyStats(float maxHealth)
    {
      MaxHealth = maxHealth;
      CurrentHealth = maxHealth;
    }

    public bool TakeDamage(float amount)
    {
      CurrentHealth -= amount;
      return CurrentHealth <= 0;
    }
  }

  // MonoBehaviour delegate
  public class BaseEnemy : MonoBehaviour
  {
    public int level = 1;
    public float maxHealth = 100f;
    private EnemyStats stats;

    void Awake() => stats = new EnemyStats(maxHealth);
    public void TakeDamage(float amount)
    {
      bool died = stats.TakeDamage(amount);
      if (died) Die();
    }
    protected virtual void Die()
    {
      Destroy(gameObject);
    }
  }
}