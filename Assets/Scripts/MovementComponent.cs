using UnityEngine;

public class MovementComponent : MonoBehaviour {
    [SerializeField] private float moveSpeed = 2f;

    private Transform target;
    private int pathIndex = 0;

    private void Start() {
        target = LevelManager.main.path[0];
    }

    private void Update() {
        if(Vector2.Distance(target.position, transform.position) <= 0.1f) {
            pathIndex++;

            if(pathIndex == LevelManager.main.path.Length) {
                Destroy(gameObject);
            } else {
                target = LevelManager.main.path[pathIndex];
            }
        }
    }

    private void FixedUpdate() {
        Vector2 direction = (target.position - transform.position).normalized;
        Move(direction);
    }

    private void Move(Vector2 direction2D) {
        Vector3 direction3D = new Vector3(direction2D.x, direction2D.y);
        transform.position += direction3D * moveSpeed * Time.deltaTime;
    }
}
