using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour {
    [SerializeField] private Button newGameButton;
    [SerializeField] private Button continueButton;
    [SerializeField] private Button quitButton;

    private void Awake() {
        // Change this to GameScene later
        newGameButton.onClick.AddListener(() => {
            Loader.Load(Loader.Scene.LoadingScene /*Loader.Scene.GameScene*/);
        });

        continueButton.onClick.AddListener(() => {
            Loader.Load(Loader.Scene.LoadingScene);
        });

        quitButton.onClick.AddListener(() => {
            Application.Quit();
        });
    }
}
