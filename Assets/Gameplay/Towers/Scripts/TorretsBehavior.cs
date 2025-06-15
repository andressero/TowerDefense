using UnityEngine;

namespace Assets.Gameplay.Towers.Scripts
{
  public class TorretsBehavior : MonoBehaviour
  {
    [SerializeField] private Transform turretRotationPoint;
    [SerializeField] private LayerMask enemyMask;
    [SerializeField] private float range = 5f;

    private Transform target;

    private void Update()
    {
      if (target == null)
      {
        FindTarget();
        return;
      }

      RotateToTarget();

      if (!CheckTargetIsInRange())
        target = null;
    }

    private void FindTarget()
    {
      Collider2D[] hits = Physics2D.OverlapCircleAll(transform.position, range, enemyMask);
      Transform closest = null;
      float minDist = float.MaxValue;

      foreach (var hit in hits)
      {
        float dist = Vector2.SqrMagnitude(hit.transform.position - transform.position);
        if (dist < minDist)
        {
          minDist = dist;
          closest = hit.transform;
        }
      }
      target = closest;
    }

    private void RotateToTarget()
    {
      Vector2 dir = (target.position - transform.position).normalized;
      float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90f;
      turretRotationPoint.rotation = Quaternion.Euler(0f, 0f, angle);
    }

    private bool CheckTargetIsInRange()
    {
      return Vector2.Distance(target.position, transform.position) <= range;
    }

    private void OnDrawGizmosSelected()
    {
      Gizmos.color = Color.yellow;
      Gizmos.DrawWireSphere(transform.position, range);
    }
  }
}