using UnityEngine;

namespace Assets.Gameplay.Enemies.Scripts
{
  public class EnemiesMovement : MonoBehaviour
  {
    [Header("References")]
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator an;

    [Header("Attributes")]
    [SerializeField] private float moveSpeed = 2f;

    private Transform target;
    private int pathIndex = 0;

    private void Start()
    {
      target = LevelManager.instance.path[pathIndex];
    }

    private void Update() 
    {
      an.SetBool("moving", true);
      if(Vector2.Distance(target.position, transform.position) <= 0.1f)
      {
        ++pathIndex;
        
        if(pathIndex == LevelManager.instance.path.Length)
        {
          Destroy(gameObject);
        }
        else
        {
          target = LevelManager.instance.path[pathIndex];
        }
      }
    }

    private void FixedUpdate()
    {
      Vector2 direction = (target.position - transform.position).normalized;
      rb.linearVelocity = direction * moveSpeed;
    }
  }
}