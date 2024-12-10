using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuPanel;
    private bool isPaused = false;

    void Start()
    {
        //ensure pause menu is hidden at start
        pauseMenuPanel.SetActive(false);
    }

    public void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            //pause game and show pause menu
            Time.timeScale = 0; //freeze game time
            pauseMenuPanel.SetActive(true);
            Debug.Log("pause menu started");
        }
        else
        {
            //resume game and hide pause menu
            Time.timeScale = 1; //resume game time
            pauseMenuPanel.SetActive(false);
            Debug.Log("pause menu resumed");
        }
    }

    public void ResumeGame()
    {
        //resume game and hide pause menu
        Time.timeScale = 1;
        pauseMenuPanel.SetActive(false);
        isPaused = false;
        Debug.Log("pause menu started");
    }

    public void ReturnToMainMenu()
    {
        //reset time scale and return to main menu
        Time.timeScale = 1;
        SceneManager.LoadScene("menu");
        Debug.Log("returned to main menu");
    }
}
