using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{

    public void StartGame()
    {
        //loading game scene
        SceneManager.LoadScene("GameScene");
        Debug.Log("game scene started");
    }
    
    public void ViewTrophies()
    {
        SceneManager.LoadScene("TrophyScene");
        Debug.Log("trophy scene started");
    }

}
