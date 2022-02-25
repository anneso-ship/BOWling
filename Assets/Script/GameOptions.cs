using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOptions : MonoBehaviour
{
    public static bool StartingGame;
    public GameObject GOgameUI;
    public GameObject EndgameUI;
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

    public void EndGame()
    {
        EndgameUI.SetActive(true);
        Time.timeScale = 0;
        StartingGame = true;
    }

    private void Awake()
    {
        PauseGame();
        EndgameUI.SetActive(false);
    }
   
}
