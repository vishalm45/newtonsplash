using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TrophyPageController : MonoBehaviour
{
    public TextMeshProUGUI[] trophyTexts; // Assign these in the Inspector

    void Start()
    {
        Debug.Log("trophy page accessed");
        // Loop through the trophies and display their status
        for (int i = 0; i < trophyTexts.Length; i++)
        {
            if (trophyManager.instance.IsTrophyUnlocked(i))
            {
                trophyTexts[i].text = $"Trophy {i + 1}: Unlocked!";
            }
            else
            {
                trophyTexts[i].text = $"Trophy {i + 1}: Locked.";
            }
        }
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("menu");
        Debug.Log("menu accessed from trophy page");
    }
}
