using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
  public static class Loader
  {

    public enum Scene
    {
      MainMenuScene,
      LoadingScene,
      GameplayScene
    }

    private static Scene targetScene;

    public static void Load(Scene targetScene) {
      Loader.targetScene = targetScene;

      SceneManager.LoadScene(Scene.LoadingScene.ToString());
    }

    public static void LoaderCallback() {
      SceneManager.LoadScene(targetScene.ToString());
    }


  }
}