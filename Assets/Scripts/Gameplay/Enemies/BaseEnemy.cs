using UnityEngine;

public abstract class BaseEnemy: MonoBehaviour
{
  [Header("Stats")]
  public int level = 1;
  public float maxHealth = 100f;
  protected float currentHealth;
  public float speed = 2f;

  protected virtual void Awake()
  {
    currentHealth = maxHealth;
  }

  public virtual void TakeDamage(float amount)
  {
    currentHealth -= amount;
    if (currentHealth <= 0) Die();
  }

  protected virtual void Die()
  {
    Destroy(gameObject);
  }
}
