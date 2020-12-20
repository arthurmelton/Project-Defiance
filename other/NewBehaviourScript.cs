using UnityEngine;

namespace other
{
    public class NewBehaviourScript : MonoBehaviour
    {
        public int gamemode;

        public int sellected;

        public DiscordController controller;

        public void playgame()
        {
            sellected = PlayerPrefs.GetInt("Selcted");
            if (sellected != 0)
                gamemode = PlayerPrefs.GetInt("gamemode");
            switch (gamemode)
            {
                case 1:
                    loader.Load(loader.Scene.game);
                    break;
                case 2:
                    loader.Load(loader.Scene.game_1);
                    break;
            }
        }

        public void quit()
        {
            Application.Quit();
        }

        public void deadreplay()
        {
            loader.Load(loader.Scene.people_select);
        }

        public void mainmenu()
        {
            loader.Load(loader.Scene.mainmenu);
        }

        public void select()
        {
            gamemode = 1;

            PlayerPrefs.SetInt("gamemode", gamemode);
            PlayerPrefs.Save();

            loader.Load(loader.Scene.people_select);
        }

        public void select1()
        {
            gamemode = 2;

            PlayerPrefs.SetInt("gamemode", gamemode);
            PlayerPrefs.Save();

            loader.Load(loader.Scene.people_select);
        }
    }
}