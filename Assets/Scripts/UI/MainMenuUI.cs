using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour {
    [SerializeField] private Button playButton;
    [SerializeField] private Button quitButton;

    private void Awake() {
        playButton.onClick.AddListener(() => {
            /*
            // Load the "loading" scene, then the level selection screen.
            SceneManager.LoadScene(sceneNameOrIndex);
             
             */
        });

        quitButton.onClick.AddListener(() => {
            Application.Quit();
        });
    }
}
