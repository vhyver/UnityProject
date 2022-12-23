using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool IsGamePaused = false;

    public GameObject pauseMenuUI;
    public GameObject pauseButton;
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        IsGamePaused = false;
        pauseButton.SetActive(true);
    }
    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        IsGamePaused = true;
        pauseButton.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsGamePaused)
            {
                Resume();
            }
            else
            {
                Pause();  
            }
        }
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
