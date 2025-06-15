using System.Runtime.CompilerServices;
using Assets.Scripts;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace UI
{
  public class MainMenuUI : MonoBehaviour
  {
    [SerializeField] private Button newGameButton;
    [SerializeField] private Button continueButton;
    [SerializeField] private Button quitButton;

    private void Awake()
    {
      // Change this to GameScene later
      newGameButton.onClick.AddListener(() => {
        Loader.Load(Loader.Scene.GameplayScene);
      });

      continueButton.onClick.AddListener(() => {
        Loader.Load(Loader.Scene.GameplayScene);
      });

      quitButton.onClick.AddListener(() => {
        Application.Quit();
      });
    }
  }
}

