using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOptions : MonoBehaviour
{
    public static bool StartingGame;
    public GameObject GOgameUI;
    public GameObject EndgameUI;
    public GameObject pauseMenuUI;
    public static bool GameIsPaused;
   


    private void Awake()
    {
        StartGame();
        pauseMenuUI.SetActive(false);
        EndgameUI.SetActive(false);
    }


    public void StartGame()
    {
        GOgameUI.SetActive(true);
        Time.timeScale = 0;
        StartingGame = true;
    }
    void Pause()
    {
        Time.timeScale = 0;
        StartingGame = true;
    }
    public void startgame()
    {//démarrer le jeu
        GOgameUI.SetActive(false);
        Time.timeScale = 1;
        StartingGame = false;
    }

    public void EndGame()
    {//Afficher le paneau de score à la fin du jeu
        EndgameUI.SetActive(true);
        Time.timeScale = 0;
        StartingGame = true;
    }

    public void ResetScene()
    {//reprendre le jeu à 0
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Resume()
    {//reprendre le jeu ,après la pause
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1;
        GameIsPaused = false;
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
           // Pause();
           // pauseMenuUI.SetActive(true);

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                //GameIsPaused = !GameIsPaused;
                if (GameIsPaused) { Resume(); pauseMenuUI.SetActive(false); }
                else { Pause(); pauseMenuUI.SetActive(true); }
            }

        }
    }


}
