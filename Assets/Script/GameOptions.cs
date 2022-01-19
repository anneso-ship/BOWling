using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOptions : MonoBehaviour
{
    public static bool StartingGame;
    public GameObject GOgameUI;

    public void PauseGame()
    {
        GOgameUI.SetActive(true);
        Time.timeScale = 0;
        StartingGame = true;
    }

    public void startgame()
    {
        GOgameUI.SetActive(false);
        Time.timeScale = 1;
        StartingGame = false;
    }

    private void Awake()
    {
        PauseGame();
    }
   
}
