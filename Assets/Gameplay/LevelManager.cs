using UnityEngine;

namespace Assets.Gameplay
{
  public class LevelManager : MonoBehaviour
  {
    public static LevelManager instance;
    public Transform starPoint;
    public Transform[] path;

    public void Awake()
    {
      instance = this;
    }
  }
}