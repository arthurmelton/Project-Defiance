using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int gamemode;

    public int sellected;

    public void playgame()
    {
        sellected = PlayerPrefs.GetInt("Selcted");
        if(sellected != 0)
        gamemode = PlayerPrefs.GetInt("gamemode");
        if(gamemode == 1) 
        {
            loader.load(loader.Scene.game);
        }

        if(gamemode == 2) 
        {
            loader.load(loader.Scene.game_1);
        }
        
    }

    public void quit()
    {
        Application.Quit();

    }

    public void deadreplay()
    {
        loader.load(loader.Scene.people_select);
    }

    public void mainmenu()
    {
        loader.load(loader.Scene.mainmenu);
    }

    public void select()
    {
        gamemode = 1;

        PlayerPrefs.SetInt("gamemode", gamemode);
        PlayerPrefs.Save();

        loader.load(loader.Scene.people_select);
    }

    public void select1()
    {
        gamemode = 2;

        PlayerPrefs.SetInt("gamemode", gamemode);
        PlayerPrefs.Save();

        loader.load(loader.Scene.people_select);
    }

}
