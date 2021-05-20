using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject topUI;
    public GameObject buildUI;

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }

        }
    }

    public void Resume()
    {
        TooltipSystem.tooltipActive = true;
        BuildManager.gameActive = true;
        pauseMenuUI.SetActive(false);
        topUI.SetActive(true);
        buildUI.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        TooltipSystem.tooltipActive = false;
        BuildManager.gameActive = false;
        pauseMenuUI.SetActive(true);
        topUI.SetActive(false);
        buildUI.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
        TooltipSystem.Hide();
    }

    public void LoadMenu(string Scenename)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(Scenename);
    }

    public void NextLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game");
        Application.Quit();
    }

}
