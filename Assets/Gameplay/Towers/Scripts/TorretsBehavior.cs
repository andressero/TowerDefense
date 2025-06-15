using UnityEditor;
using UnityEngine;

namespace Assets.Gameplay.Towers.Scripts
{
  public class TorretsBehavior : MonoBehaviour
  {
    [Header("References")]
    [SerializeField] private Transform turretRotationPoint;

    [Header("Attributes")]
    [SerializeField] private float range = 5f;

    private void OnDrawGizmosSelected()
    {
      Handles.color = Color.yellow;
      Handles.DrawWireDisc(transform.position, transform.forward, range);
    }
  }
}