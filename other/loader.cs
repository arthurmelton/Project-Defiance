using System;
using UnityEngine.SceneManagement;

namespace other
{
    public static class loader
    {
        public enum Scene
        {
            game,
            loading_scene,
            mainmenu,
            people_select,
            game_1
        }

        private static Action onLoaderCallback;

        public static void Load(Scene scene)
        {
            onLoaderCallback = () => { SceneManager.LoadScene(scene.ToString()); };

            SceneManager.LoadScene(Scene.loading_scene.ToString());
        }

        public static void LoaderCallback()
        {
            if (onLoaderCallback != null)
            {
                onLoaderCallback();
                onLoaderCallback = null;
            }
        }
    }
}