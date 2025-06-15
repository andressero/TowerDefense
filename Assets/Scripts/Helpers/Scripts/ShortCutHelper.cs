using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Helpers.Scripts
{
  public class ShortCutHelper : MonoBehaviour
  {
    static void Update()
    {
      // Detectar Ctrl (o Cmd en macOS) + A
      if ((Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
          && Input.GetKeyDown(KeyCode.E))
      {
        // Opcional: desbloquear cursor si estuvo bloqueado
        Cursor.lockState = CursorLockMode.None;
        // Cambio de escena
        SceneManager.LoadScene(Loader.Scene.MainMenuScene.ToString());
      }
    }
  }
}