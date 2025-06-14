using UnityEngine;

public class EnemiesMovement : MonoBehaviour
{
  [Header("References")]
  [SerializeField] private Rigidbody2D rb;


  [Header("Attributes")]
  [SerializeField] private float moveSpeed = 2f;

  private Transform target;
  private int pathIndex = 0;

  private void Start()
  {
    target = 
  }
}
